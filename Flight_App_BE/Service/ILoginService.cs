using Flight_App_BE.Models;
using Flight_App_BE.UserCred;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_App_BE.Service
{
    public interface ILoginService
    {
        Login login(Login userCreds);
        Login Register(User user);
    }
}
