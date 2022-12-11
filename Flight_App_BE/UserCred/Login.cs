using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_App_BE.UserCred
{
    public class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string? token { get; set; }
    }
}
