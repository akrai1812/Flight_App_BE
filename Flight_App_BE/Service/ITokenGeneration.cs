using Flight_App_BE.AdminCred;
using Flight_App_BE.UserCred;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_App_BE.Service
{
    public interface ITokenGeneration
    {
        public string GenerateToken(Login userCreds);
        public string GenerateToken(AdminLogin adminCreds);
    }
}
