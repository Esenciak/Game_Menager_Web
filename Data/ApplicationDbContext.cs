using Game_Menager_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Game_Menager_Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
        {
            
        }

        //Klasa która będzie tworzona i obsługiwana, nazwa to 
        // Table które będzie tworzone w SQL
        public DbSet<Category> Categories { get; set; }
        public DbSet<Hero> Heroes { get; set; }
    }
}
