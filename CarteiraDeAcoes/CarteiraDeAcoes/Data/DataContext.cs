using CarteiraDeAcoes.Model;
using Microsoft.EntityFrameworkCore;


namespace CarteiraDeAcoes.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Acao> Acoes { get; set; }

    }
}
