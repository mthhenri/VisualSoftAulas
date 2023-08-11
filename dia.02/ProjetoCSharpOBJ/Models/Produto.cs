namespace ProjetoCSharpOBJ.Models;
public class Produto
{
    private string Nome;
    private double Valor;
    private int Qtd;

    public string GetNome()
    {
        return Nome;
    }

    public void SetNome(string nome)
    {
        Nome = nome;
    }

    public double GetValor()
    {
        return Valor;
    }

    public void SetValor(double valor)
    {
        Valor = valor;
    }

    public int GetQtd()
    {
        return Qtd;
    }

    public void SetQtd(int qtd)
    {
        Qtd = qtd;
    }
}
