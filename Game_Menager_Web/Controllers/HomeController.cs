using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Game_Menager.Models;

namespace Game_Menager_Web.Controllers
{
    public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			// przekierowuje na index
			return View();
		}

		public IActionResult Privacy()
		{
			// przekierowuje na privacy
			return View();
		}


		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
