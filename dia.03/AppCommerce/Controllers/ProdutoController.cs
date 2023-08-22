namespace AppCommerce.Controllers;

using AppCommerce.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/produto")]

public class ProdutoController : ControllerBase
{
    private List<Produto> listaProdutos = new();

    [HttpGet("listar")]
    public ActionResult<List<Produto>>? ListarProdutos()
    {
        try
        {
            return listaProdutos;
        }
        catch (System.Exception)
        {
            return null;
        }
    }

    [HttpGet("detalhar/{id}")]
    public ActionResult<Produto>? DetalharProduto(long id)
    {
        try
        {
            foreach (Produto produto in listaProdutos){
                if(produto.Id == id){
                    return produto;
                }
            }
            return null;
        }
        catch (System.Exception)
        {
            return null;
        }
    }

    [HttpPost("cadastrar")]
    public ActionResult<string> CadastrarProduto()
    {
        try
        {
            Produto produtoNovo = new();
            listaProdutos.Add(produtoNovo);
            return "Produto cadastrado!";
        }
        catch (System.Exception)
        {
            return "";
        }
    }

    [HttpPut("atualizar/{id}")]
    public ActionResult<string> AtualizarProduto(long id)
    {
        try
        {
            foreach (Produto produto in listaProdutos){
                if(produto.Id == id){
                    return "Produto atualizado!";
                }
            }
            return "Erro!";
        }
        catch (System.Exception)
        {
            return "";
        }
    }

    [HttpDelete("deletar/{id}")]
    public ActionResult<string> DeletarProduto(long id){
        try
        {
            foreach (Produto produto in listaProdutos){
                if(produto.Id == id){
                    return "Produto removido!";
                }
            }
            return "Erro!";
        }
        catch (System.Exception)
        {
            return "";
        }
    }
}
