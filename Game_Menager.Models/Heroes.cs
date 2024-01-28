using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Game_Menager.Models
{
    public class Heroes
    {
        private DateTime _createdDateTime;

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nazwa nie może być pusta")]
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
        [DisplayName("Broń")]
        public string Weapon { get; set; }

        [Required]
        [DisplayName("Umiejętność Główna")]
        public string Skill { get; set; }

        [Required]
        [DisplayName("Poziom Głównej Umiejętności")]
        public int SkillRank { get; set; }

        [Required]
        [MaxLength(1000)]
        [DisplayName("Opis Głównej umiejętności")]
        public string SkillDescription { get; set; }

        [Required]
        [DisplayName("Umiejętność 2")]
        public string Skill2 { get; set; }

        [Required]
        [DisplayName("Poziom Umiejętności 2")]
        public int SkillRank2 { get; set; }

        [Required]
        [MaxLength(1000)]
        [DisplayName("Opis Umiejętności 2")]
        public string SkillDescription2 { get; set; }

        [Required]
        [DisplayName("Umiejętność 3")]
        public string Skill3 { get; set; }

        [Required]
        [DisplayName("Poziom Umiejętności 3")]
        public int SkillRank3 { get; set; }

        [Required]
        [MaxLength(1000)]
        [DisplayName("Opis Umiejętności 3")]
        public string SkillDescription3 { get; set; }

        [Required]
        [DisplayName("Umiejętność 4")]
        public string Skill4 { get; set; }

        [Required]
        [DisplayName("Poziom Umiejętności 4")]
        public int SkillRank4 { get; set; }

        [Required]
        [MaxLength(1000)]
        [DisplayName("Opis Umiejętności 4")]
        public string SkillDescription4 { get; set; }

        [Required]
        [Range(1, 10000, ErrorMessage = "Numer musi być pomiędzy 1-10000")]
        [DisplayName("Level")]
        public int Level { get; set; }

        public DateTime CreatedDateTime
        {
            get { return DateTime.Now; }
            set { _createdDateTime = value; }
        }
    }
}
