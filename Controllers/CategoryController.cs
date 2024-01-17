using Game_Menager_Web.Data;
using Game_Menager_Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Game_Menager_Web.Controllers
{
    public class CategoryController : Controller
    {
        
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            // dodaje naszą liste do strony
            List<Category> objCategoryList = _db.Categories.ToList();
            // przekierowuje na stronę do logowania
            return View(objCategoryList);
        }
    }
}
