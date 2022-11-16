
namespace Financeiro.API.Models
{
    public class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id {get; set;}
    }
}