using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Flight_App_BE.Models;

namespace Flight_App_BE.Data
{
    public class Flight_App_BEContext : DbContext
    {
        public Flight_App_BEContext (DbContextOptions<Flight_App_BEContext> options)
            : base(options)
        {
        }

        public DbSet<Flight_App_BE.Models.User> User { get; set; }

        public DbSet<Flight_App_BE.Models.Flight> Flight { get; set; }

        public DbSet<Flight_App_BE.Models.Booking> Booking { get; set; }

        public DbSet<Flight_App_BE.Models.Admin> Admin { get; set; }

        public DbSet<Flight_App_BE.Models.Contactus> Contactus { get; set; }
    }
}
