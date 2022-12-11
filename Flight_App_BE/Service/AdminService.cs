using Flight_App_BE.Data;
using Flight_App_BE.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Flight_App_BE.Service
{
    public class AdminService : IAdminService
    {
        private readonly Flight_App_BEContext _flight_App_BEContext;
        public AdminService(Flight_App_BEContext flight_App_BEContext)
        { _flight_App_BEContext = flight_App_BEContext; }
        public Admin AddAdmin(Admin admin)
        {
            try
            {
                _flight_App_BEContext.Admin.Add(admin); _flight_App_BEContext.SaveChanges();
                return admin;
            }
            catch (Exception) { throw; }

        }

        public List<Admin> GetAllAdmin()
        {
            if (_flight_App_BEContext.Admin.Count() > 0)
                return _flight_App_BEContext.Admin.ToList();
            return null;
        }
    }
}
