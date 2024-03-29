﻿using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class Jogador
{
    private int _id;
    private string _nome;
    private string _cor;
    private string _senha;
    public Carta cartasMao = new Carta();

    public Color colorPirata;
    public Image ImgPirata;

    public int Id
    {
        get => _id;
        set => _id = value;
    }
    public string Nome
    {
        get => _nome;
        set => _nome = value;
    }
    public string Cor
    {
        get => _cor;
        set => _cor = value;
    }
    public string Senha
    {
        get => _senha;
        set => _senha = value;
    }

    public void ReceberCartas()
    {
        string cartas = Jogo.ConsultarMao(this._id, this._senha);
        cartas.Replace("\r", "");

        string[] cartaTipoQnt = cartas.Split('\n');

        for (int i = 0; i < cartaTipoQnt.Length; i++)
        {
            string[] carta = cartaTipoQnt[i].Split(',');
            if (cartaTipoQnt[i].StartsWith("E"))
            {
                cartasMao.esqueletoQnt = Convert.ToInt32(carta[1]);
            }
            else if (cartaTipoQnt[i].StartsWith("F"))
            {
                cartasMao.facaQnt = Convert.ToInt32(carta[1]);
            }
            else if (cartaTipoQnt[i].StartsWith("G"))
            {
                cartasMao.garrafaQnt = Convert.ToInt32(carta[1]);
            }
            else if (cartaTipoQnt[i].StartsWith("T"))
            {
                cartasMao.tricornioQnt = Convert.ToInt32(carta[1]);
            }
            else if (cartaTipoQnt[i].StartsWith("C"))
            {
                cartasMao.chaveQnt = Convert.ToInt32(carta[1]);
            }
            else if (cartaTipoQnt[i].StartsWith("P"))
            {
                cartasMao.pistolaQnt = Convert.ToInt32(carta[1]);
            }
        }
    }

    public List<Pirata> Jogar(Partida partida, List<Pirata> piratas, string carta = "", int posPirata = -1)
    {
        string[] VerificaVezETabuleiro = Jogo.VerificarVez(partida.Id).Replace("\r", "").Split('\n');
        string[] PrimeiraLinhaVerificaVez = VerificaVezETabuleiro[0].Split(',');
        string retornoPiratas = Jogo.VerificarVez(partida.Id);

        piratas = AtualizarPiratas(piratas, retornoPiratas);

        // Verifica se é a vez do bot
        if (PrimeiraLinhaVerificaVez[0] == "J" && Convert.ToInt32(PrimeiraLinhaVerificaVez[1]) == this.Id)
        {
            if (carta == "" && posPirata == -1)
            {
                // Pula a vez
                Jogo.Jogar(this.Id, this.Senha);
                //System.Windows.Forms.MessageBox.Show(Jogo.VerificarVez(partida.Id));
                return piratas;
            }

            int contadorDeLinhas = 0;

            // Itera sobre todos os piratas
            for (int i = 0; i < piratas.Count; i++)
            {
                // Verifica se existe piratas do Jogador na posição selecionada
                if (posPirata == piratas[i].PosTabuleiro && this.Id == piratas[i].idJogador)
                {
                    // Verifica se o jogador jogou alguma carta
                    if (carta == "")
                    {
                        // RETORNA PIRATA
                        retornoPiratas = Jogo.Jogar(this.Id, this.Senha, piratas[i].PosTabuleiro);

                        if (retornoPiratas.StartsWith("ERRO"))
                        {
                            System.Windows.Forms.MessageBox.Show(retornoPiratas);
                        }
                        else {
                            //System.Windows.Forms.MessageBox.Show(Jogo.VerificarVez(partida.Id));
                            contadorDeLinhas--;
                        }
                    }
                    // Caso ele jogue uma carta
                    else
                    {
                        // AVANÇA COM O PIRATA
                        retornoPiratas = Jogo.Jogar(this.Id, this.Senha, posPirata, carta);

                        if (retornoPiratas.StartsWith("ERRO"))
                        {
                            System.Windows.Forms.MessageBox.Show(retornoPiratas);
                        }
                        else
                        {
                            //System.Windows.Forms.MessageBox.Show(Jogo.VerificarVez(partida.Id));
                            contadorDeLinhas--;
                        }
                    }
                    piratas = AtualizarPiratas(piratas, retornoPiratas);
                    break;
                }
                else
                {
                    contadorDeLinhas++;
                }
            }
            if (contadorDeLinhas == piratas.Count)
            {
                //System.Windows.Forms.MessageBox.Show(Jogo.VerificarVez(partida.Id));
                System.Windows.Forms.MessageBox.Show("NÃO TEM PIRATA NA POSIÇÃO INDICADA");
            }
        }
        else
        {
            System.Windows.Forms.MessageBox.Show("NÃO É A SUA VEZ");
        }
        return piratas;
    }

    public List<Pirata> AtualizarPiratas(List<Pirata> piratas, string retornoPiratas)
    {
        int j = 0;

        piratas.Clear();

        /*if (retornoPiratas.EndsWiths('\n'))
        {
            retornoPiratas = retornoPiratas.Substring(0, retornoPiratas.Length - 2)
        }*/

        // array = retorno.Replace("\r", "").Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

        string[] linhas = retornoPiratas.Replace("\r", "").Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string linha in linhas)
        {
            string[] coluna = linha.Split(',');

            if (j != 0 && j != linhas.Length)
            {
                Pirata auxiliar = new Pirata();
                auxiliar.PosTabuleiro = Convert.ToInt32(coluna[0]);

                auxiliar.idJogador = Convert.ToInt32(coluna[1]);

                auxiliar.qntPiratas = Convert.ToInt32(coluna[2]);

                piratas.Add(auxiliar);
            }
            j++;
        }
        return piratas;
    }

    public void Estrategia(Partida partida, List<Pirata> piratas)
    {
        int pos = OndeGanharCarta(partida, piratas);
        if (pos != 0 && pos != 37)
        {
            this.Jogar(partida, piratas, "", pos);
        }
        else
        {
            pos = this.IdentificarOUltimo(piratas);

            if (cartasMao.esqueletoQnt > 0)
            {
                this.Jogar(partida, piratas, "E", pos);
                cartasMao.esqueletoQnt--;
            }
            else if (cartasMao.facaQnt > 0)
            {
                this.Jogar(partida, piratas, "F", pos);
                cartasMao.facaQnt--;
            }
            else if (cartasMao.garrafaQnt > 0)
            {
                this.Jogar(partida, piratas, "G", pos);
                cartasMao.garrafaQnt--;
            }
            else if (cartasMao.tricornioQnt > 0)
            {
                this.Jogar(partida, piratas, "T", pos);
                cartasMao.tricornioQnt--;
            }
            else if (cartasMao.chaveQnt > 0)
            {
                this.Jogar(partida, piratas, "C", pos);
                cartasMao.chaveQnt--;
            }
            else if (cartasMao.pistolaQnt > 0)
            {
                this.Jogar(partida, piratas, "P", pos);
                cartasMao.pistolaQnt--;
            }
            else {
                pos = this.IdentificarOPrimeiro(piratas);
                this.Jogar(partida, piratas, "", pos);
            }
        }
    }
    public int IdentificarOUltimo(List<Pirata> piratas)
    {
        List<int> posMeusPiratas = new List<int>();
        foreach (Pirata p in piratas)
        {
            if (this.Id == p.idJogador)
            {
                posMeusPiratas.Add(p.PosTabuleiro);
            }
        }

        return posMeusPiratas.Min();
    }

    public int IdentificarOPrimeiro(List<Pirata> piratas)
    {
        List<int> posMeusPiratas = new List<int>();
        foreach (Pirata p in piratas)
        {
            if (this.Id == p.idJogador)
            {
                posMeusPiratas.Add(p.PosTabuleiro);
            }
        }

        return posMeusPiratas.Max();
    }

    public int OndeGanharCarta(Partida partida, List<Pirata> piratas)
    {
        for (int i = piratas.Count - 1; i >= 0; i--)
        {
            if (piratas[i].idJogador == this.Id) {
                int qntPiratas = this.QntPiratasNaPosição(piratas, piratas[i].PosTabuleiro);

                if (qntPiratas == 2)
                {
                    return piratas[i].PosTabuleiro;
                }
                break;
            }
        }
        return 0;
    }

    private int QntPiratasNaPosição(List<Pirata> piratas, int pos)
    {
        int qntPiratas = 0;
        foreach (Pirata p in piratas)
        {
            if (p.PosTabuleiro == pos)
            {
                qntPiratas += p.qntPiratas;
            }
            j++;
        }
        return qntPiratas;
    }
}

