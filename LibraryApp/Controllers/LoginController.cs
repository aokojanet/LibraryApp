
using LibraryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Controllers
{
	public class LoginController : Controller
	{
		private readonly LibrarySystemDb _librarySystemDb;
		public LoginController(LibrarySystemDb librarySystemDb)
		{
			_librarySystemDb = librarySystemDb;
		}
		public IActionResult Login()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Login(Models.Users user)
		{

			if (User == null)
			{
				return View();
			}
			var selectedUser = _librarySystemDb.Users.Where(p => p.UserName == user.UserName && p.Password == user.Password).FirstOrDefault();


			if (selectedUser == null)
			{
				ViewBag.Error = "Invalid Username /Password";
				return View();
			}
			else
			{
				if (selectedUser != null)
				{
					return View("DashboardUsers");
				}
			}
			return View();
		}
		
	}
}
