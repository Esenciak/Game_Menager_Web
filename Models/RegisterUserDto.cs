using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Game_Menager_Web.KiedysFront;

namespace Game_Menager_Web.Models
{
    public class RegisterUserDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [MinLength(7)]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public int RoleId { get; set; } = 1;

    }
}
