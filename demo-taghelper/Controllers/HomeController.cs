using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using MvcDi.Models;
using MvcDi.Repositories;

namespace MvcDi.Controllers
{
    public class HomeController : Controller
    {
		public IActionResult Index()
        {
            return View();
        }
	}
}