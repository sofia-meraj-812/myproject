using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication10.Models
{
    public class Appointment
    {
        public int id { get; set; }
        public DateTime date { get; set; }

        [ForeignKey("pat")]
        public int patid { get; set; }

        public Patient pat { get; set; }

        [ForeignKey("doc")]
        public int docid { get; set; }

        public Doctor doc { get; set; }

        public int time { get; set; }



    }
}