using Microsoft.EntityFrameworkCore;
using Projeto_Imobiliaria.Models;

namespace Projeto_Imobiliaria.DBContext
{
    public class ImovelContext : DbContext
    {
        public ImovelContext(DbContextOptions<ImovelContext> options): base(options)
        {

        }

        public DbSet<Imovel> Imovel { get; set; }
    }
}
