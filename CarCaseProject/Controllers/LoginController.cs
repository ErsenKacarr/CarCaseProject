using CarCaseProject.Context;
using CarCaseProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CarCaseProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        CaseContext context = new CaseContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var result = context.Admins.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);
            if (result != null)
            {
                FormsAuthentication.SetAuthCookie(admin.Username, true);
                Session["username"] = result.Username;
                return RedirectToAction("CarList", "AdminCar");
            }
            return View();
        }
    }
}