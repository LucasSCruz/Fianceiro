using Financeiro.API.Data;
using Financeiro.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovimentacaoController : Controller
    {
        private DataContext _dataContext;

        public void PessoasController(DataContext context)
        {
            _dataContext = context;
        }

        [HttpGet("api/getMovimentacao")]
        public ActionResult<IEnumerable<Movimentacao>> GetMovimentacao()
        {
            _dataContext = new DataContext();

            var data = _dataContext.GetMovimentacao();

            return data.ToList();
        }

         [HttpPost("api/createMovimentacao")]
        public async Task<ActionResult> Cadastro([FromBody]Movimentacao Movimentacao)
        {
            _dataContext = new DataContext();

            _dataContext.Movimentacao.Add(Movimentacao);
            await _dataContext.SaveChangesAsync();

            return Created("Objeto pessoa", Movimentacao);
        }

        [HttpPut("api/atualizaMovimentacao")]
        public async Task<ActionResult> Atualiza([FromBody] Movimentacao Movimentacao)
        {
            _dataContext = new DataContext();

            if (Movimentacao == null)
            {
                return BadRequest("Not found!");
            }

            _dataContext.Movimentacao.Update(Movimentacao);
            await _dataContext.SaveChangesAsync();

            return Ok("Updated!");
        }

         [HttpDelete("api/deleteMovimentacao")]
        public async Task<ActionResult> Delete([FromBody] Movimentacao Movimentacao)
        {
            _dataContext = new DataContext();

            if(Movimentacao == null)
            {
                return BadRequest("Not found!");
            }

            _dataContext.Movimentacao.Remove(Movimentacao);
            await _dataContext.SaveChangesAsync();

            return Ok("Deleted!");

        } 
    }
}