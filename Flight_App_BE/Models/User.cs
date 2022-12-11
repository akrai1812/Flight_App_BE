using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_App_BE.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }



        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        [StringLength(10)]
        public string Mobile { get; set; }
    }
}
