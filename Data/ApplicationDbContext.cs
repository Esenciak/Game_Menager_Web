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
 

        // tworzy Db Hero w SQL
        public DbSet<Heroes> Heroes { get; set; }

        // dodaje dane do bazy sql Heroes
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Heroes>().HasData(
                new Heroes
                {
                    Id = 1,
                    Name = "Legolas",
                    Description = "elf pochodzący ze szczepu Sindarów. W Trzeciej Erze był członkiem Drużyny Pierścienia.",
                    Age = 1200,
                    Race = "Elf",
                    HP = 70,
                    Speed = 120,
                    Gold = 20,
                    Strenght = 40,
                    Dexterity = 100,
                    Mana = 20,
                    Gender = "Male",
                    Weapon = "Bow",
                    Skill = "Ciche kroki",
                    SkillRank = 5,
                    SkillDescription = "Postać porusza się bezszelestnie",
                    Level = 12
                }
                );
        }
            

    }
}
