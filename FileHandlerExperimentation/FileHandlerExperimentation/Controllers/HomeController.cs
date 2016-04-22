using System;
using System.IO;
using System.Web.Mvc;

namespace FileHandlerExperimentation.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult MultiUpload()
		{
			return View();
		}

		public ActionResult Upload()
		{
			var now = DateTime.Now.ToString("s").Replace(":", "_").Replace("-", "_");
			for (var i = 0; i < Request.Files.Count; ++i)
			{
				var file = Request.Files[i];
				if (file == null) continue;
				if (string.IsNullOrWhiteSpace(file.FileName)) continue;

				var uploadPath = Path.Combine(Server.MapPath("~/App_Data/Upload/"), now + "___" + file.FileName);
				file.SaveAs(uploadPath);
			}

			return View();
		}
	}
}
