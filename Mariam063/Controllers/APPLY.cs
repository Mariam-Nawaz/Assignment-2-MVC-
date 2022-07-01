using Microsoft.AspNetCore.Mvc;

namespace Mariam063.Controllers
{
	public class APPLY : Controller
	{
		public IActionResult Index()
		{
			ViewBag.Message = "mariam";
			ViewBag.m2 = "nawaz";
			return View("onlineapply");
		}
	}
}
