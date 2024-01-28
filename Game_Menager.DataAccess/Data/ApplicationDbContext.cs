using Game_Menager.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Game_Menager.DataAccess.Data
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

            base.OnModelCreating(modelBuilder);

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
                    Skill2 = "Szybkie strzelanie",
                    Skill3 = "Wysoki skok",
                    Skill4 = "Sokole oko",
                    SkillRank = 5,
                    SkillRank2 = 5,
                    SkillRank3 = 5,
                    SkillRank4 = 5,
                    SkillDescription = "Postać porusza się bezszelestnie",
                    SkillDescription2 = "Postać Wystrzeliwuje serię strzał",
                    SkillDescription3 = "Postać skaczę wysoko",
                    SkillDescription4 = "Postać widzi na znaczną odległość",
                    Level = 12,
                    User = "Karol"
                   
                }
                );
        }
            

    }
}
