using Microsoft.AspNetCore.Identity;

namespace Game_Menager_Web.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Role { get; set; }
    }
    
}
