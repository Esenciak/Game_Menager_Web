using Microsoft.AspNetCore.Mvc;
using Game_Menager.DataAccess.Repository;

namespace Game_Menager_Web.Areas.Gracz.Controllers
{
    [Area("Gracz")]
    public class KartaPostaciGraczController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
