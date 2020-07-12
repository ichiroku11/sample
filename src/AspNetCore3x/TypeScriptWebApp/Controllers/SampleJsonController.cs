using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TypeScriptWebApp.Controllers {
	public class Sample {
		public int Number { get; set; }
		public string Text { get; set; }
	}

	[Route("api/[controller]")]
	[ApiController]
	public class SampleJsonController : ControllerBase {
		public object Get() {
			return new Sample {
				Number = 1,
				Text = "a",
			};
		}

		[HttpPost]
		public object Post(Sample sample) {
			return sample;
		}
	}
}
