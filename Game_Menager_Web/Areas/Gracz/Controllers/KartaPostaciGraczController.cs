using Microsoft.AspNetCore.Mvc;
using Game_Menager.DataAccess.Repository;
using Game_Menager.DataAccess.Repository.IRepository;
using Game_Menager.Models;

namespace Game_Menager_Web.Areas.Gracz.Controllers
{
	[Area("Gracz")]
	public class KartaPostaciGraczController : Controller
	{

        private readonly IHeroesRepository _HeroesRepo;
        public KartaPostaciGraczController(IHeroesRepository db)
        {
            _HeroesRepo = db;
        }

        public IActionResult Index()
        {
            // dodaje naszą liste do strony
            List<Heroes> objHeroesList = _HeroesRepo.GetAll().ToList();
            // przekierowuje na stronę do logowania asddasdas
            return View(objHeroesList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Heroes obj)
        {
            if (obj.Name != null && obj.Name.ToLower() == "test")
            {
                ModelState.AddModelError("", "Test is an invalid value");
            }
            if (ModelState.IsValid)
            {
                _HeroesRepo.Add(obj); // dodaje do tabeli
                _HeroesRepo.Save(); // zapisujemy zmiany w bazie 
                TempData["success"] = "Udało się stworzyć postać";
                return RedirectToAction("Index"); // przekierwoujemy się z powrotem na index
            }
            return View();
        }

        public IActionResult KartaPos(int? Heroesid)
        {
            Heroes? obj = _HeroesRepo.Get(u => u.Id == Heroesid);
            if (obj == null)
            {
                return NotFound();
            }
            Heroes obj2 = _HeroesRepo.Get(u => u.Id == Heroesid);
            if (obj == null)
            {
                return NotFound();
            }
            TempData["success"] = "Udało się załadować postać";
            return View(obj2);



        }

    }
}
