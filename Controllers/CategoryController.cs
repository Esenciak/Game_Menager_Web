using Microsoft.AspNetCore.Mvc;

namespace Game_Menager_Web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
