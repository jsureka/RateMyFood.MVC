using Microsoft.EntityFrameworkCore;

namespace RateMyFood.MVC.Models
{
    public class RateMyFoodDbContext : DbContext
    {
        public RateMyFoodDbContext(DbContextOptions<RateMyFoodDbContext> options) : base(options) 
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }

    }
}
