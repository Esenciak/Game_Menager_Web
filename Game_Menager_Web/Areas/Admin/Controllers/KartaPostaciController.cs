using Game_Menager.Models;
using Game_Menager.DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Game_Menager_Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class KartaPostaciController : Controller
    {
        private readonly IHeroesRepository _HeroesRepo;
        public KartaPostaciController(IHeroesRepository db)
        {
            _HeroesRepo = db;
        }

        public IActionResult Index()
        {
            // dodaje naszą liste do strony
            List<Heroes> objHeroesList = _HeroesRepo.GetAll().ToList();
            // przekierowuje na stronę do logowania
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

        //edycja
        public IActionResult Edit(int? Heroesid)
        {
            if (Heroesid == null || Heroesid == 0)
            {
                return NotFound();
            }
            Heroes? heroesFromDb = _HeroesRepo.Get(u => u.Id == Heroesid);
            //Heroes heroesFromDb2 = _db.Heroes.FirstOrDefault(u=>u.Id==id); inne werjse wyszukiwania id do edycji
            //Heroes heroesFromDb3 = _db.Heroes.Where(u=>u.Id==id).FirstOrDefault();
            if (heroesFromDb == null)
            {
                return NotFound();
            }
            return View(heroesFromDb);
        }


        [HttpPost]
        public IActionResult Edit(Heroes obj)
        {
            if (ModelState.IsValid)
            {
                _HeroesRepo.Update(obj); // dodaje do tabeli
                _HeroesRepo.Save(); // zapisujemy zmiany w bazie 
                TempData["success"] = "Udało się edytować postać";
                return RedirectToAction("Index"); // przekierwoujemy się z powrotem na index
            }
            return View();
        }


        // usuwanie
        public IActionResult Delete(int? Heroesid)
        {
            if (Heroesid == null || Heroesid == 0)
            {
                return NotFound();
            }
            Heroes? obj = _HeroesRepo.Get(u => u.Id == Heroesid);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Heroes? obj = _HeroesRepo.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _HeroesRepo.Remove(obj);
            _HeroesRepo.Save(); // zapisujemy zmiany w bazie 
            TempData["success"] = "Udało się usunąć postać";
            return RedirectToAction("Index"); // przekierwoujemy się z powrotem na index

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
