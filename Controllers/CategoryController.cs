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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
		public IActionResult Create(Category obj)
		{
            if(obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "DisplayOrder cannot exacly match the Name");
            }
			if (obj.Name != null && obj.Name.ToLower() == "test")
			{
				ModelState.AddModelError("", "Test is an invalid value");
			}
			if (ModelState.IsValid)
            {
				_db.Categories.Add(obj); // dodaje do tabeli
				_db.SaveChanges(); // zapisujemy zmiany w bazie 
				return RedirectToAction("Index"); // przekierwoujemy się z powrotem na index
			}
            return View();
		}

	}
}
