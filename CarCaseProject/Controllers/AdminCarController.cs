using CarCaseProject.Context;
using CarCaseProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarCaseProject.Controllers
{
    public class AdminCarController : Controller
    {

        CaseContext context = new CaseContext();
        public ActionResult CarList()
        {
            var values = context.Cars.ToList();
            return View(values);
        }


        [HttpGet]
     
        public ActionResult CreateCar()
        {

            return View();
        }

        [HttpPost]
 
        public ActionResult CreateCar(Car car)
        {
            context.Cars.Add(car);
            context.SaveChanges();
            return RedirectToAction("CarList");
        }

        public ActionResult DeleteCar(int id)
        {
            var value = context.Cars.Find(id);
            context.Cars.Remove(value);
            context.SaveChanges();
            return RedirectToAction("CarList");
        }

        [HttpGet]
        public ActionResult UpdateCar(int id)
        {
            var value = context.Cars.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateCar(Car car)
        {
            var value = context.Cars.Find(car.CarID);
            value.CarName = car.CarName;
            value.LicensePlate = car.LicensePlate;
            value.ActiveWorkingTime = car.ActiveWorkingTime;
            value.MaintenanceTime = car.MaintenanceTime;
            value.IdleTime = car.IdleTime;
            value.TotalTime = car.TotalTime;
            context.SaveChanges();
            return RedirectToAction("CarList");
        }
    }
}