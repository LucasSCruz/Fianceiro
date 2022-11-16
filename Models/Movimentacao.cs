
using System.ComponentModel.DataAnnotations.Schema;

namespace Financeiro.API.Models
{
    public class Movimentacao : Entity
    {
        public string nomeMovimentacao {get; set;}
        public string tipo {get; set;}
        public double valor {get; set;}
        public DateTime DataCriacao {get; set;}

        [ForeignKey("Conta")]
        public Guid contaId {get; set;}

        [ForeignKey("Banco")]
        public Guid bancoId {get; set;}
    }
}