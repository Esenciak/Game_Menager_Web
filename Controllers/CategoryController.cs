using Microsoft.AspNetCore.Mvc;

namespace Game_Menager_Web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            // przekierowuje na stronę do logowania
            return View();
        }
    }
}
