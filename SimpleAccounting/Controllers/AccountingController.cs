using System.Web.Mvc;

namespace SimpleAccounting.Controllers
{
    public class AccountingController : Controller
    {
        [ActionName("chart-of-account")]
        public ActionResult ChartOfAccount()
        {
            return View("ChartOfAccount");
        }
	}
}