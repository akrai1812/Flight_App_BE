using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_App_BE.Models
{
    [Table("Contactus")]
    public class Contactus
    {
        [Key]
        public int Cid { get; set; }



        public string Name { get; set; }



        public string Email { get; set; }



        public string Type { get; set; }



        public string Message { get; set; }
    }
}
