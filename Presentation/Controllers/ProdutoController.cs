using IA.Interfaces.Service;
using IA.Entities;
using Microsoft.AspNetCore.Mvc;

namespace IA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var resultado = _produtoService.Get(id);
            return Ok(resultado);
        }

        [HttpGet]
        public IActionResult All()
        {
            var resultados = _produtoService.All();
            return Ok(resultados);
        }

        [HttpPost]
        public ActionResult<Produto> Post(Produto produto)
        {
            _produtoService.Add(produto);
            return CreatedAtAction(nameof(Get), new { id = produto.Id }, produto);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = _produtoService.Get(id);
            if (item == null)
            {
                return NotFound();
            }
            _produtoService.Delete(item);
            return NoContent();
        }
    }
}