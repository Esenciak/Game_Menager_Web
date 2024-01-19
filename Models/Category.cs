using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Game_Menager_Web.Models
{
    public class Category
    {
        // to jest klucz mega potrzebny
        [Key]
        public int Id { get; set; }
        [Required] // to oznacza że name musi być inaczej nie puści 
        // jak wywołamu w np html Name to wyświetli się Category name
        [MaxLength(30)] // maksymalnie 30 znaków
		[DisplayName("Category Name")]
		public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="Numer musi być pomiędzy 1-100")] // numer w zakresie od 1 do 100, custom error message
        public int DisplayOrder { get; set; }

        //Można użyć do zapisywania daty edycji
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
