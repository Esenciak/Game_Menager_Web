using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Game_Menager_Web.Models;
using Game_Menager_Web.KiedysFront;
using Microsoft.Identity.Client;
using Game_Menager_Web.Data;
using Microsoft.AspNetCore.Identity;

namespace Game_Menager_Web.KiedysFront
{
    public interface IAccountService
    {
        void RegisterUser(RegisterUserDto dto);
    }
    public class AccountService : IAccountService
    {
        private readonly ApplicationDbContext _context;
        private readonly IPasswordHasher<User> _passwordHasher;
        public AccountService(ApplicationDbContext context, IPasswordHasher<User> passwordHasher) 
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }
        public void RegisterUser(RegisterUserDto dto)
        {
            
            var newUser = new User()
            {
                UserName = dto.UserName,
                Email = dto.Email,
                RoleId = dto.RoleId
            };
            var hashedPassword = _passwordHasher.HashPassword(newUser, dto.Password);

            newUser.PasswordHash = hashedPassword; 
            _context.User.Add(newUser);
            _context.SaveChanges();
        }
    }
}
