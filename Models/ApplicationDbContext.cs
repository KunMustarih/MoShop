using Microsoft.EntityFrameworkCore;


namespace MoShop.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions options):base(options) { }


        public DbSet<ShoppingCartItem> Shirts { get; set; }

    }

    
}
