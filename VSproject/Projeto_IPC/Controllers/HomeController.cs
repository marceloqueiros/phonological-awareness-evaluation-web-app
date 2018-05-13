using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto_IPC.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SobreNos()
        {
            return View();
        }

    }
}