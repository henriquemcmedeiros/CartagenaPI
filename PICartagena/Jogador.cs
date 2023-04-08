public class Jogador
{
    private int _id;
    private string _nome;
    private string _cor;
    private string _senha;
    // public Cartas cartas;

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
}
