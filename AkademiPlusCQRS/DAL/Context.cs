using Microsoft.EntityFrameworkCore;

namespace AkademiPlusCQRS.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
            optionsBuilder.UseSqlServer("server=DESKTOP-5SF4DGP\\SQLEXPRESS;initial catalog=AkademiPlusCQRSDb;integrated security=true");
            }
        public DbSet<Product> Products { get; set; }
    }
}
