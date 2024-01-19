using System.ComponentModel.DataAnnotations;

namespace Game_Menager_Web.Models
{
    public class Heroes
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Nazwa nie może być pusta")]
		[MaxLength(30)]
		public string Name { get; set; }
		[Required]
		public string Description { get; set; } = "test";
		[Required]
		[Range(1, 10000, ErrorMessage = "Numer musi być pomiędzy 1-10000")]
		public int Age { get; set; } = 20;
		[Required]
		[MaxLength(30)]
		public string Race { get; set; } = "test";
		[Required]
		[Range(1, 100, ErrorMessage = "Numer musi być pomiędzy 1-100")]
		public int HP { get; set; } = 10;
		[Required]
		[Range(1, 100, ErrorMessage = "Numer musi być pomiędzy 1-100")]
		public int Speed { get; set; } = 10;
		[Required]
		public int Gold { get; set; } = 10;
		[Required]
		[Range(1, 100, ErrorMessage = "Numer musi być pomiędzy 1-100")]
		public int Strenght { get; set; } = 10;
		[Required]
		[Range(1, 100, ErrorMessage = "Numer musi być pomiędzy 1-100")]
		public int Dexterity { get; set; } = 10;
		[Required]
		[Range(1, 999, ErrorMessage = "Numer musi być pomiędzy 1-999")]
		public int Mana { get; set; } = 10;
		[Required]
		[Range(1, 100, ErrorMessage = "0=Mężczyzna 1=Kobieta")]
		public int Male { get; set; } = 0;
		[Required]
		[MaxLength(30)]
		public string Weapon { get; set; } = "test";
		[Required]
		[MaxLength(40)]
		public string Skill { get; set; } = "test";
		[Required]
		public int SkillRank { get; set; } = 10;
		[Required]
		[MaxLength(50)]
		public string SkillDescription { get; set; } = "test";

		public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
