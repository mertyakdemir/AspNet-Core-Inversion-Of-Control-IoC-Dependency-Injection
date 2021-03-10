using IOC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IOC.Web.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ISingletonDateService _singletonDateService;

        //private readonly IScopedDateService _scopedDateService;

        private readonly ITransientDateService _transientDateService;


        public HomeController
            (
            // ISingletonDateService singletonDateService
            // IScopedDateService scopedDateService
            ITransientDateService transientDateService
            )
        {
            //_singletonDateService = singletonDateService;
            // _scopedDateService = scopedDateService;
            _transientDateService = transientDateService;
        }

        public IActionResult Index
            (
            // [FromServices] ISingletonDateService singletonDateService2
            // [FromServices] IScopedDateService scopedDateService2)
            [FromServices] ITransientDateService transientDateService2)
        {
            ViewBag.Time1 = _transientDateService.GetDateTime.TimeOfDay.ToString();
            ViewBag.Time2 = transientDateService2.GetDateTime.TimeOfDay.ToString();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
