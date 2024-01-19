using Game_Menager_Web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Game_Menager_Web.Controllers
{
    public class KartaPostaciController : Controller
    {
        private readonly ApplicationDbContext _db;
        public KartaPostaciController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: KartaPostaci
        public ActionResult Index()
        {
            return View();
        }

        // GET: KartaPostaci/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KartaPostaci/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KartaPostaci/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KartaPostaci/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KartaPostaci/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KartaPostaci/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KartaPostaci/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
