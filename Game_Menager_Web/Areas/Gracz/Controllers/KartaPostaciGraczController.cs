using Microsoft.AspNetCore.Mvc;
using Game_Menager.DataAccess.Repository;
using Game_Menager.DataAccess.Repository.IRepository;

namespace Game_Menager_Web.Areas.Gracz.Controllers
{
	[Area("Gracz")]
	public class KartaPostaciGraczController : Controller
	{
		private readonly IHeroesRepository _heroesRepository;

		public KartaPostaciGraczController(IHeroesRepository heroesRepository)
		{
			_heroesRepository = heroesRepository;
		}

		public IActionResult Index()
		{
			// Retrieve the user's ID (assuming you have authentication set up)
			string userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

			// Get heroes for the current user
			var heroes = _heroesRepository.GetHeroesForUser(userId);

			return View(heroes);
		}
	}
}
