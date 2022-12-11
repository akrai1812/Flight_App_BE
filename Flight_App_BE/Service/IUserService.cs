using Flight_App_BE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_App_BE.Service
{
    public interface IUserService
    {
        List<User> GetAllUser();
        User AddUser(User user);
    }
}
