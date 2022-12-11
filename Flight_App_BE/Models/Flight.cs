﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_App_BE.Models
{
    [Table("Flight")]
    public class Flight
    {
        [Key]
        public int Id { get; set; }

        public string Fname { get; set; }

        public string Fsource { get; set; }



        public string Fdestination { get; set; }



        public DateTime Fdepttime { get; set; }



        public DateTime Farrtime { get; set; }



        public string Totpass { get; set; }



        public string BusinessFare { get; set; }
        public string FirstClassFare { get; set; }
        public string EconomyFare { get; set; }

    }
}
