using Microsoft.AspNetCore.Mvc;
using TAP_Test.Models;

namespace TAP_Test.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet, Route("Get-Message")]
        public IActionResult GetMessage()
        {
            UserInfo user = new UserInfo { FirstName = "John", LastName = "Eads" };



            return Ok($"{user.FirstName} {user.LastName} can suck it");
        }
    }
}