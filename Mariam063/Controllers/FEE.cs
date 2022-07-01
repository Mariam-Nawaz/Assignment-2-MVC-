using Microsoft.AspNetCore.Mvc;

namespace Mariam063.Controllers
{
	public class FEE : Controller
	{
		public IActionResult Index()
		{
			return View("feeview");
		}
	}
}
