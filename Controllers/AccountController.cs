using Game_Menager_Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Menager_Web.KiedysFront;

namespace Game_Menager_Web.Controllers
{
	[Route("api/account")] //usuna� w razie potrzeby
    [ApiController]
	public class AccountControler : Controller
	{
		private readonly IAccountService _accountService;
		public AccountControler(IAccountService accountService) 
		{
			_accountService = accountService;
		}
		[HttpPost("register")] //usuna� w razie potrzeby
		public ActionResult RegisterUser([FromBody] RegisterUserDto dto)
		{
			_accountService.RegisterUser(dto);
			return View("OK");
		}
	}
}
