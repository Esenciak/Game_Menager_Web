using Game_Menager_Web.Data;
using Game_Menager_Web.Models;
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

		public IActionResult Index()
		{
			// dodaje naszą liste do strony
			List<Heroes> objHeroesList = _db.Heroes.ToList();
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
				_db.Heroes.Add(obj); // dodaje do tabeli
				_db.SaveChanges(); // zapisujemy zmiany w bazie 
				TempData["success"] = "Udało się stworzyć postać";
				return RedirectToAction("Index"); // przekierwoujemy się z powrotem na index
			}
			return View();
		}

		//edycja
		public IActionResult Edit(int? Heroesid)
		{
			if(Heroesid == null || Heroesid == 0)
			{
				return NotFound();
			}
			Heroes heroesFromDb = _db.Heroes.Find(Heroesid);
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
				_db.Heroes.Update(obj); // dodaje do tabeli
				_db.SaveChanges(); // zapisujemy zmiany w bazie 
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
			Heroes obj = _db.Heroes.Find(Heroesid);
			if (obj == null)
			{
				return NotFound();
			}
			return View(obj);
		}


		[HttpPost, ActionName("Delete")]
		public IActionResult DeletePOST(int? id)
		{
			Heroes? obj = _db.Heroes.Find(id);
			if (obj == null) 
			{
				return NotFound();
			}
			_db.Heroes.Remove(obj);
			_db.SaveChanges(); // zapisujemy zmiany w bazie 
			TempData["success"] = "Udało się usunąć postać";
			return RedirectToAction("Index"); // przekierwoujemy się z powrotem na index

		}


		public IActionResult KartaPos()
		{
			Heroes hero = _db.Heroes.FirstOrDefault();
			return View(hero);
		}


		//[HttpPost]
		//public IActionResult Karta(Heroes obj)
		//{
		//	if (ModelState.IsValid)
		//	{
		//		_db.Heroes.Update(obj); // dodaje do tabeli
		//		_db.SaveChanges(); // zapisujemy zmiany w bazie 
		//		TempData["success"] = "Udało się edytować postać";
		//		return RedirectToAction("Index"); // przekierwoujemy się z powrotem na index
		//	}
		//	return View();
		//}




	}
}
