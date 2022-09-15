using Projeto_Imobiliaria.Models;
using Microsoft.EntityFrameworkCore;


namespace Projeto_Imobiliaria.DBContext
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}
