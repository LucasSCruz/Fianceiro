
using System.ComponentModel.DataAnnotations.Schema;

namespace Financeiro.API.Models
{
    public class Banco : Entity
    {
        public string nomeBanco {get; set;}
        public string tipo {get; set;}
        public DateTime DataCriacao {get; set;}

        [ForeignKey("Conta")]
        public Guid contaId {get; set;}
    }
}