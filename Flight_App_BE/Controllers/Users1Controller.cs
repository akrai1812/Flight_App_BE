using Flight_App_BE.Data;
using Flight_App_BE.Models;
using Flight_App_BE.Service;
using Flight_App_BE.UserCred;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_App_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Users1Controller : ControllerBase
    {
        private readonly ILoginService _loginService;
        private readonly Flight_App_BEContext _context;

        public Users1Controller(Flight_App_BEContext context, ILoginService loginService)
        {
            _context = context;
            _loginService = loginService;

        }

        [HttpPost]
        [Route("Login")]
        public ActionResult Login(Login user)
        {
            var result = _loginService.login(user);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Invalid userName or Password");
        }
        [HttpPost]
        [Route("Register")]
        public ActionResult Register(User user)
        {
            var result = _loginService.Register(user);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not able to register");
        }
    }
}
