using System.ComponentModel.DataAnnotations;

namespace Game_Menager_Web.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }

        //Można użyć do zapisywania daty edycji
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
