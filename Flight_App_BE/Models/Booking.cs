﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_App_BE.Models
{
    [Table("Booking")]
    public class Booking
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int BookingId { get; set; }




        [Required]
        [ForeignKey("FlightId")]
        public int FlightId { get; set; }
        public Flight Flight { get; set; }




        [Required]
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime BookingDate { get; set; }
        public string PName { get; set; }
        public string PAge { get; set; }
        public string PGender { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public string Class { get; set; }
        public string NPass { get; set; }
        public string Fare { get; set; }
    }
}
