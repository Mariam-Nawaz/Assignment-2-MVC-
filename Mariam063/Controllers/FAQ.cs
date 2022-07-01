using Microsoft.AspNetCore.Mvc;

namespace Mariam063.Controllers
{
	public class FAQ : Controller
	{
		public IActionResult Index()
		{
			return View("viewfaq");
		}
	}
}
