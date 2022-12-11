using Flight_App_BE.AdminCred;
using Flight_App_BE.Models;

namespace Flight_App_BE.Service
{
    public interface IAdminLoginService
    {
        AdminLogin adminlogin(AdminLogin adminCreds);
        AdminLogin Register(Admin admin);
    }

}
