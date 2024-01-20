using Microsoft.AspNetCore.Mvc;
using Game_Menager_Web.Data;
using System.Linq;

namespace Game_Menager_Web.Controllers
{
	public class KartaPosController : Controller
	{
		private readonly ApplicationDbContext _db;

		public KartaPosController(ApplicationDbContext db)
		{
			_db = db;
		}

		public IActionResult KartaPos()
		{
			var heroesList = _db.Heroes.ToList();
			return View(heroesList);
		}
	}
}
