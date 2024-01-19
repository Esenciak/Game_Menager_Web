using Microsoft.AspNetCore.Mvc;

namespace Game_Menager_Web.Controllers
{
    public class KartaPostaciController : Controller
    {
        public IActionResult Index()
        {
            // przekierowuje na index
            return View();
        }
    }
}
