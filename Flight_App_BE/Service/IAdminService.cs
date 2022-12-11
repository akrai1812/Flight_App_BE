using Flight_App_BE.Models;
using System.Collections.Generic;

namespace Flight_App_BE.Service
{
    public interface IAdminService
    {
        List<Admin> GetAllAdmin();
        Admin AddAdmin(Admin user);
    }

}
