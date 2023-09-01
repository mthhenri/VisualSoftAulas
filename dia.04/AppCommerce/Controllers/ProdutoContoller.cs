namespace AppCommerce.Controllers;

using System.Threading.Tasks;
using AppCommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[ApiController]
[Route("api/produto")]
public class ProdutoController : ControllerBase
{
    [HttpGet]
    [Route("listar")]
    public async Task<IActionResult> ListarProdutos()
    {
        try
        {
            using (var manager = new Database())
            {
                return Ok(await manager.Produtos.ToListAsync());
            }
        }
        catch (System.Exception error)
        {
            return NotFound(error);
        }
    }

    [HttpPost]
    [Route("cadastrar")]
    public async Task<IActionResult> CadastrarProduto([FromBody] Produto produto)
    {
        try
        {
            using (var manager = new Database())
            {
                manager.Produtos.Add(produto);
                await manager.SaveChangesAsync();
                return Created("Produto criado!", produto);
            }
        }
        catch (System.Exception error)
        {
            return BadRequest(error);
        }
    }

    [HttpGet]
    [Route("procurar/{id}")]
    public async Task<IActionResult> ProcurarProduto([FromRoute] int id)
    {
        try
        {
            using (var manager = new Database())
            {

            }
        }
        catch (System.Exception error)
        {
            return NotFound(error);
        }
    }

    [HttpPut]
    [Route("atualizar/{id}")]
    public async Task<IActionResult> AtualizarProduto([FromRoute] int id)
    {
        try
        {
            using (var manager = new Database())
            {

            }
        }
        catch (System.Exception error)
        {
            return BadRequest(error);
        }
    }

    [HttpDelete]
    [Route("deletar/{id}")]
    public async Task<IActionResult> DeletarProduto([FromRoute] int id)
    {
        try
        {
            using (var manager = new Database())
            {

            }
        }
        catch (System.Exception error)
        {
            return BadRequest(error);
        }
    }
}
