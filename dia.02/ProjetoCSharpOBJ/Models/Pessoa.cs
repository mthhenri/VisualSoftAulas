namespace ProjetoCSharpOBJ;
public class Pessoa
{
    public string? Nome { get; set; }
    public Random? Idade { get; set; }
    public double Altura { get; set; }

    override public string ToString()
    {
        return $"Nome: {Nome} | Idade: {Idade} | Altura: {Altura}" ;
    }
}