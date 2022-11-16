using Financeiro.API.Data;
using Financeiro.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaController : Controller
    {
        private DataContext _dataContext;

        public void PessoasController(DataContext context)
        {
            _dataContext = context;
        }

        [HttpGet("api/getConta")]
        public ActionResult<IEnumerable<Conta>> GetConta()
        {
            _dataContext = new DataContext();

            var data = _dataContext.GetConta();

            return data.ToList();
        }

         [HttpPost("api/createConta")]
        public async Task<ActionResult> Cadastro([FromBody]Conta Conta)
        {
            _dataContext = new DataContext();

            _dataContext.Conta.Add(Conta);
            await _dataContext.SaveChangesAsync();

            return Created("Objeto pessoa", Conta);
        }

        [HttpPut("api/atualizaConta")]
        public async Task<ActionResult> Atualiza([FromBody] Conta Conta)
        {
            _dataContext = new DataContext();

            if (Conta == null)
            {
                return BadRequest("Not found!");
            }

            _dataContext.Conta.Update(Conta);
            await _dataContext.SaveChangesAsync();

            return Ok("Updated!");
        }

         [HttpDelete("api/deleteConta")]
        public async Task<ActionResult> Delete([FromBody] Conta Conta)
        {
            _dataContext = new DataContext();

            if(Conta == null)
            {
                return BadRequest("Not found!");
            }

            _dataContext.Conta.Remove(Conta);
            await _dataContext.SaveChangesAsync();

            return Ok("Deleted!");

        } 
 
    }
}