﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValidatableObjectWebApp.Models;

namespace ValidatableObjectWebApp.Controllers {
	public class DefaultController : Controller {
		public IActionResult Index() {
			return View();
		}

		[HttpPost]
		public IActionResult Index(UserFormModel model) {
			return View();
		}
	}
}