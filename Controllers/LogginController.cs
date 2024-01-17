using Microsoft.AspNetCore.Mvc;

namespace Game_Menager_Web.Controllers
{
    public class LogginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
