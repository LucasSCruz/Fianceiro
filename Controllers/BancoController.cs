using Financeiro.API.Data;
using Financeiro.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BancoController : Controller
    {
        private DataContext _dataContext;

        public void PessoasController(DataContext context)
        {
            _dataContext = context;
        }

        [HttpGet("api/getBanco")]
        public ActionResult<IEnumerable<Banco>> GetBanco()
        {
            _dataContext = new DataContext();

            var data = _dataContext.GetBanco();

            return data.ToList();
        }

         [HttpPost("api/createBanco")]
        public async Task<ActionResult> Cadastro([FromBody]Banco Banco)
        {
            _dataContext = new DataContext();

            _dataContext.Banco.Add(Banco);
            await _dataContext.SaveChangesAsync();

            return Created("Objeto pessoa", Banco);
        }

        [HttpPut("api/atualizaBanco")]
        public async Task<ActionResult> Atualiza([FromBody] Banco Banco)
        {
            _dataContext = new DataContext();

            if (Banco == null)
            {
                return BadRequest("Not found!");
            }

            _dataContext.Banco.Update(Banco);
            await _dataContext.SaveChangesAsync();

            return Ok("Updated!");
        }

         [HttpDelete("api/deleteBanco")]
        public async Task<ActionResult> Delete([FromBody] Banco Banco)
        {
            _dataContext = new DataContext();

            if(Banco == null)
            {
                return BadRequest("Not found!");
            }

            _dataContext.Banco.Remove(Banco);
            await _dataContext.SaveChangesAsync();

            return Ok("Deleted!");

        } 
 
    }
}