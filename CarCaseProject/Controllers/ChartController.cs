using CarCaseProject.Context;
using CarCaseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarCaseProject.Controllers
{
    [AllowAnonymous]
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Chart()
        {
            return Json(Car(), JsonRequestBehavior.AllowGet);
        }
        public List<Chart1> Car()
        {
            List<Chart1> cs = new List<Chart1>();
            CaseContext context = new CaseContext();
            cs = context.Cars.Select(x => new Chart1
            {
                CarName = x.CarName,
                ActiveWorkingTime = x.ActiveWorkingTime,
                TotalTime = x.TotalTime,
                Yuzde = x.ActiveWorkingTime/x.TotalTime * 100
            }).ToList();        
            return cs;
        }


        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult Chart2()
        {
            return Json(Car2(), JsonRequestBehavior.AllowGet);
        }
        public List<Chart2> Car2()
        {
            List<Chart2> cs2 = new List<Chart2>();
            CaseContext context = new CaseContext();
            cs2 = context.Cars.Select(x => new Chart2
            {
                CarName = x.CarName,
                IdleTime = x.IdleTime,
                TotalTime = x.TotalTime,
                Yuzde = x.IdleTime / x.TotalTime * 100
            }).ToList();
            return cs2;
        }
    }
}