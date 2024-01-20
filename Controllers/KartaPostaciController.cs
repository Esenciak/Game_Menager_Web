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
				return RedirectToAction("Index"); // przekierwoujemy się z powrotem na index
			}
			return View();
		}
		public IActionResult Edit(int? id)
		{
			if(id==null || id==0)
			{
				return NotFound();
			}
			Heroes heroesFromDb = _db.Heroes.Find(id);
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
			if (obj.Name != null && obj.Name.ToLower() == "test")
			{
				ModelState.AddModelError("", "Test is an invalid value");
			}
			if (ModelState.IsValid)
			{
				_db.Heroes.Add(obj); // dodaje do tabeli
				_db.SaveChanges(); // zapisujemy zmiany w bazie 
				return RedirectToAction("Index"); // przekierwoujemy się z powrotem na index
			}
			return View();
		}



	}
}
