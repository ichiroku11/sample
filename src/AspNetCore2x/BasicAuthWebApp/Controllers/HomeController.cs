using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BasicAuthWebApp.Controllers {
	public class HomeController : Controller {
		public IActionResult Index() {
			return Content($"{nameof(HomeController)}.{nameof(HomeController.Index)}");
		}
	}
}
