using Flight_App_BE.Data;
using Flight_App_BE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_App_BE.Service
{
    public class UserService:IUserService
    {
        private readonly Flight_App_BEContext _flight_App_BEContext;
        public UserService(Flight_App_BEContext flight_App_BEContext)
        { _flight_App_BEContext= flight_App_BEContext; }
        public User AddUser(User user)
        {
            try { _flight_App_BEContext.User.Add(user); _flight_App_BEContext.SaveChanges(); 
                return user; 
            }
            catch (Exception) { throw; }

        }

        public List<User> GetAllUser()
        {
            if (_flight_App_BEContext.User.Count() > 0)
                return _flight_App_BEContext.User.ToList();
            return null;
        }
    }
}
