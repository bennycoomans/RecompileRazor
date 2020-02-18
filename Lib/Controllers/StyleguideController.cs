using Microsoft.AspNetCore.Mvc;

namespace Lib.Controllers
{
	[Route("styleguide")]
	public class StyleguideController : Controller
	{
		[HttpGet]
		[Route("atoms")]
		public IActionResult Atoms()
		{
			return View();
		}
	}
}