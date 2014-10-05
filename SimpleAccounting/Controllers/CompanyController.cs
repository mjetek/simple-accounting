using SimpleAccounting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleAccounting.Controllers
{
    public class CompanyController : Controller
    {
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult AddUser()
        {
            return View();
        }
	}
}