using CarCaseProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarCaseProject.Context
{
    public class CaseContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}