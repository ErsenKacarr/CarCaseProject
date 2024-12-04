using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarCaseProject.Entities
{
    public class Car
    {
        public int CarID { get; set; }
        public string CarName { get; set; }
        public string LicensePlate { get; set; }
        public float ActiveWorkingTime { get; set; }
        public float MaintenanceTime { get; set; }
        public float IdleTime { get; set; }
        public float TotalTime { get; set; }
    }
}