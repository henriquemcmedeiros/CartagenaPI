using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

public class Jogador
{
    private int _id;
    private string _nome;
    private string _cor;
    private string _senha;
    public Cartas cartasMao = new Cartas();

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

    public List<Piratas> Jogar(Partida partida, List<Piratas> piratas, string carta = null, int posPirata = -1)
    {
        string[] VerificaVezETabuleiro = Jogo.VerificarVez(partida.Id).Replace("\r", "").Split('\n');
        string[] PrimeiraLinhaVerificaVez = VerificaVezETabuleiro[0].Split(',');
        string retornoPiratas = Jogo.VerificarVez(partida.Id);

        piratas = AtualizarPiratas(piratas, retornoPiratas);

        // Itera sobre todos os piratas
        for (int i = 0; i < piratas.Count; i++)
        {
            // Verifica se é a vez do bot
            if (PrimeiraLinhaVerificaVez[0] == "J" && Convert.ToInt32(PrimeiraLinhaVerificaVez[1]) == this.Id)
            {
                // Verifica se existe piratas do Jogador na posição selecionada
                if (posPirata == piratas[i].PosTabuleiro && this.Id == piratas[i].idJogador)
                {
                    // Verifica se o jogador jogou alguma carta
                    if (carta == "")
                    {
                        // RETORNA PIRATA
                        retornoPiratas = Jogo.Jogar(this.Id, this.Senha, piratas[0].PosTabuleiro);

                        piratas = AtualizarPiratas(piratas, retornoPiratas);
                        MessageBox.Show(Jogo.VerificarVez(partida.Id));
                    }
                    // Caso ele jogue uma carta
                    else
                    {
                        // AVANÇA COM O PIRATA
                        retornoPiratas = Jogo.Jogar(this.Id, this.Senha, posPirata, carta);

                        string[] linhas = retornoPiratas.Split('\n');

                        piratas = AtualizarPiratas(piratas, retornoPiratas);
                        MessageBox.Show(Jogo.VerificarVez(partida.Id));
                    }
                }
                else if (carta == "" && posPirata == -1)
                {
                    // Pula a vez
                    Jogo.Jogar(this.Id, this.Senha);
                }
                else
                {
                    MessageBox.Show(Jogo.VerificarVez(partida.Id));
                    return piratas;
                }
            }
            else
            {
                MessageBox.Show("NÃO É A SUA VEZ");
            }
        }
        MessageBox.Show(Jogo.VerificarVez(partida.Id));
        return piratas;
    }

    public List<Piratas> AtualizarPiratas(List<Piratas> piratas, string retornoPiratas)
    {
        Piratas auxiliar = new Piratas();
        int j = 0;

        piratas.Clear();

        string[] linhas = retornoPiratas.Replace("\r", "").Split('\n');

        foreach (string linha in linhas)
        {
            if (j != 0 && j != linhas.Length - 1)
            {
                string[] coluna = linha.Split(',');

                auxiliar.PosTabuleiro = Convert.ToInt32(coluna[0]);
                auxiliar.idJogador = Convert.ToInt32(coluna[1]);
                auxiliar.qntPiratas = Convert.ToInt32(coluna[2]);

                piratas.Add(auxiliar);
            }
            j++;
        }
        return piratas;
    }
}

