using System.ComponentModel;
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
		[Range(0, 999, ErrorMessage = "Numer musi być pomiędzy 0-999")]
		public int Mana { get; set; } = 10;
		[Required]
		public string Gender { get; set; } = "Male";
		[Required]
		[MaxLength(30)]
		[DisplayName("Broń")]
		public string Weapon { get; set; } = "test";
		[Required]
		[MaxLength(40)]
		[DisplayName("Umiejętność Główna")]
		public string Skill { get; set; } = "test";
		[Required]
		[DisplayName("Poziom Głównej Umiejętności")]
		public int SkillRank { get; set; } = 10;
		[Required]
		[MaxLength(50)]
		[DisplayName("Opis Głównej umiejętności")]
		public string SkillDescription { get; set; } = "test";

		public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
