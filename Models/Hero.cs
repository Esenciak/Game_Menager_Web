using System.ComponentModel.DataAnnotations;

namespace Game_Menager_Web.Models
{
    public class Hero
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public string Race { get; set; }
        public int HP { get; set; }
        public int Speed { get; set; }
        public int Gold { get; set; }
        public int Strenght { get; set; }
        public int Dexterity { get; set; }
        public int Mana { get; set; }
        public int Male { get; set; } = 0;
        public string Weapon { get; set; }
        public string Skill { get; set; }
        public int SkillRank { get; set; }
        public string SkillDescription { get; set; }
    }
}
