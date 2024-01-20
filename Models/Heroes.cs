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
		[DisplayName("Imie")]
		public string Name { get; set; }
		[Required]
		[DisplayName("Opis")]
		public string Description { get; set; }
		[Required]
		[Range(1, 10000, ErrorMessage = "Numer musi być pomiędzy 1-10000")]
		[DisplayName("Wiek")]
		public int Age { get; set; }
		[Required]
		[MaxLength(30)]
		[DisplayName("Rasa")]
		public string Race { get; set; }
		[Required]
		[Range(1, 100, ErrorMessage = "Numer musi być pomiędzy 1-100")]
		public int HP { get; set; }
		[Required]
		[Range(1, 100, ErrorMessage = "Numer musi być pomiędzy 1-100")]
		[DisplayName("Szybkość")]
		public int Speed { get; set; }
		[Required]
		[DisplayName("Złoto")]
		public int Gold { get; set; }
		[Required]
		[Range(1, 100, ErrorMessage = "Numer musi być pomiędzy 1-100")]
		[DisplayName("Siła")]
		public int Strenght { get; set; }
		[Required]
		[Range(1, 100, ErrorMessage = "Numer musi być pomiędzy 1-100")]
		[DisplayName("Zwinność")]
		public int Dexterity { get; set; }
		[Required]
		[Range(0, 999, ErrorMessage = "Numer musi być pomiędzy 0-999")]
		public int Mana { get; set; }
		[Required]
		[DisplayName("Płeć")]
		public string Gender { get; set; }
		[Required]
		[MaxLength(30)]
		[DisplayName("Broń")]
		public string Weapon { get; set; }
		[Required]
		[MaxLength(40)]
		[DisplayName("Umiejętność Główna")]
		public string Skill { get; set; }
		[Required]
		[DisplayName("Poziom Głównej Umiejętności")]
		public int SkillRank { get; set; }
		[Required]
		[MaxLength(500)]
		[DisplayName("Opis Głównej umiejętności")]
		public string SkillDescription { get; set; }

		public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
