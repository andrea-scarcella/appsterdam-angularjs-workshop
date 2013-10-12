using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace workshop.Controllers
{
	public class HomeController : Controller
	{
		//
		// GET: /Home/

		public ActionResult Index()
		{
			return View();
		}
		public ActionResult DataBinding()
		{
			return View();
		}

		public ActionResult CssSamples()
		{
			return View();
		}
		public ActionResult TodoList()
		{
			return View();
		}
	}
}
