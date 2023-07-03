using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        [Route("user/register")]
        public IActionResult SaveUser([FromBody] UserModel user)
        {
            BusinessLayer dal = new BusinessLayer();
            return Created("",dal.SaveUser(user));
        }
        [HttpPost]
        [Route("user/login")]
        public IActionResult AuthenticateUser([FromBody] LoginModel login)
        {
            DataAccessLayer dal = new DataAccessLayer();
            bool isAuthenticated = dal.AuthenticateUser(login.email, login.password);
            if (isAuthenticated)
            {
                return StatusCode(201, new { Status = "Success" });
            }
            else
            {
                 return BadRequest(new { Status = "Error", Error = "Wrong Email or Password" });
            }
        }
    }
}