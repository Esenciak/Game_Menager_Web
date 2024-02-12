using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Game_Menager_Web.Data;
using Game_Menager_Web.Models;

namespace Game_Menager_Web
{
    public class DandDSeeder
    {
        private readonly ApplicationDbContext _dbContext;
        public DandDSeeder(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void seed()
        {
           if(_dbContext.Database.CanConnect())
            {
                if(!_dbContext.Heroes.Any())
                {
                    var Hero = GetHero();
                    _dbContext.Heroes.AddRange(Hero);
                    _dbContext.SaveChanges();
                }
            }

        }
        private IEnumerable<Heroes> GetHero()
        {
            var Hero = new List<Heroes>()
            {
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
                    Level = 12
                },
            };
            return Hero;
        }
    }
}
