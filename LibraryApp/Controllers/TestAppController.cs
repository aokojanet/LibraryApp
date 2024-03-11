using LibraryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{
	public class TestAppController : Controller
	{
		private readonly LibrarySystemDb _dbcontext;

        public TestAppController(LibrarySystemDb dbcontext)
        {
			_dbcontext = dbcontext;   
        }

        public IActionResult AuthorList()
		{
			var authors = _dbcontext.Authors.ToList();

			return View(authors);
		}
	}
}
