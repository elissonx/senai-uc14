using ExoApiFST1.Models;
using Microsoft.EntityFrameworkCore;

namespace ExoApiFST1.Contexts
{
    public class ExoApiContext : DbContext
    {
        public ExoApiContext()
        {
        }

        public ExoApiContext(DbContextOptions<ExoApiContext>options)
            : base(options)
        {
        }
        // método para configurar o banco de dados

        protected override void
            
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = JULIANA\\SQLEXPRESS; initial catalog = ExoApi; Integrated Security = true;");
            }
        }
        // dbset representa entidades que serão utilizadas nas operações de leitura, criação, atualização e deleção

        public DbSet<Projeto> Projetos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
