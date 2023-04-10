using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Eventing.Reader;

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

    public void Jogar(Partida partida, Dictionary<int, int> piratas, string carta = null, int idpirata = -1)
    {
        string[] retorno = Jogo.VerificarVez(partida.Id).Replace("\r", "").Split('\n');

        string[] retorno2 = retorno[0].Split(',');

        int retornoPirata = piratas[idpirata];

        if (retorno2[1] == "J" && Convert.ToInt32(retorno2[1]) == this.Id)
        {
            // Pula a vez
            if (carta == "" && idpirata == -1)
            {
                Jogo.Jogar(this.Id, this.Senha);
            }
            // Volta um pirata
            else if (carta == null)
            {
                retornoPirata = Convert.ToInt32(Jogo.Jogar(this.Id, this.Senha, piratas[idpirata]));
            }
            // Avança com o pirata
            else
            {
                retornoPirata = Convert.ToInt32(Jogo.Jogar(this.Id, this.Senha, piratas[idpirata], carta));
            }
            piratas[idpirata] = retornoPirata;
        }

    }
}
