// See https://aka.ms/new-console-template for more information
using ProjetoCSharpOBJ;
using ProjetoCSharpOBJ.Models;

Console.WriteLine("Hello, World!");

Produto produto = new();
produto.SetNome("Banana");
produto.SetValor(10);
produto.SetQtd(500);
Console.Clear();
Console.Write(produto.GetNome() + " - R$ " + produto.GetValor() + " | Quantidade: " + produto.GetQtd());

Pessoa pessoa = new()
{
    Nome = "Matheus"
};
Console.WriteLine("\n" + pessoa);