using DIPExample.Data;
using DIPExample.Models;
using DIPExample.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DIPExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;   
        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            var res = _userServices.CreateUser(user);
            return Ok(res);
        }

    }
}
