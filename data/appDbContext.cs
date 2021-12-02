using Microsoft.EntityFrameworkCore;
using pruebaTecnica.Models;

namespace pruebaTecnica.data
{
    public class appDbContext : DbContext
    {
       


        public appDbContext(DbContextOptions<appDbContext> options): base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Mecanico> Mecanico { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<DesgloseServicios> DesgloseServicios { get; set; }
        public DbSet<DesgloseRepuestos> DesgloseRepuestos { get; set; }


    }
}
