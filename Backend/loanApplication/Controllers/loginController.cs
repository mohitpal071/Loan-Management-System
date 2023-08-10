using loanApplication.model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace loanApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class loginController : ControllerBase
    {
        private UserRepository _userRepository;
        //public CarController()
        //{
        //    this._carRepository = new CarRepository();
        //}

        public loginController(UserRepository u)
        {
            if (u != null)
            {
                _userRepository = u;
            }
        }

        [HttpPost]
        public IActionResult PostLoginDetails(User user)
        {

            if (_userRepository.ValidateUser(user)) return Ok(new { a = "b" });
            else return BadRequest();
            //return Ok(new { a = "b" });

        }
    }
}
