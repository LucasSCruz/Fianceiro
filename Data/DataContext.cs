using Financeiro.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("data source=localhost;Database=Financeiro;User Id=sa;Password=lucas869259;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Conta> Conta { get; set; }
        public DbSet<Banco> Banco { get; set; }
        public DbSet<Movimentacao> Movimentacao { get; set; }
        public IEnumerable<Conta> GetConta()
        {
            return Conta;
        }

        public IEnumerable<Banco> GetBanco()
        {
            return Banco;
        }

        public IEnumerable<Movimentacao> GetMovimentacao()
        {
            return Movimentacao;
        }
    }
}