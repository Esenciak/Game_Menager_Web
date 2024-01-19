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
		[DisplayName("Category Name")]
		public string Name { get; set; }
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }

        //Można użyć do zapisywania daty edycji
      //  public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
