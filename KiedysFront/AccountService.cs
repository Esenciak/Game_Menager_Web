using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Game_Menager_Web.Models;
using Game_Menager_Web.KiedysFront;
using Microsoft.Identity.Client;
using Game_Menager_Web.Data;

namespace Game_Menager_Web.KiedysFront
{
    public interface IAccountService
    {
        void RegisterUser(RegisterUserDto dto);
    }
    public class AccountService
    {
        private readonly ApplicationDbContext _context;
        public AccountService(ApplicationDbContext context) 
        {
            _context = context;
        }
        public void RegisterUser(RegisterUserDto dto)
        {
            
            var newUser = new User()
            {
                UserName = dto.UserName,
                Email = dto.Email,
                RoleId = dto.RoleId
            };

            _context.User.Add(newUser);
            _context.SaveChanges();
        }
    }
}
