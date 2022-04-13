using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication10.Models
{
    public class HContext:DbContext
    {

        public DbSet<Doctor> doctor { get; set; }

        public DbSet<Patient> patient { get; set; }

      


        public DbSet<Appointment> appointment { get; set; }
        public System.Data.Entity.DbSet<Schedule> Schedules { get; set; }
    }
}