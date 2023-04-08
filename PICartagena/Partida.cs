using System.Drawing;

public class Partida
{
    private int _id;
    private int _idJogadorAtual;
    private string _nome;
    private string _senha;
    public string status;
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
    public string Data { get; set; }
    public string Senha
    {
        get => _senha;
        set => _senha = value;
    }
    public int IdJogadorAtual
    {
        get => _idJogadorAtual;
        set => _idJogadorAtual = value;
    }
}

