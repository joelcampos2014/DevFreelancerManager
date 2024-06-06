using DevFreela.Application.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateUserInputModel createUserModel)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, createUserModel);
        }

        [HttpPut("{id}/login")]
        public IActionResult Login(int id, [FromBody] LoginInputModel loginModel)
        {
            return NoContent();
        }
    }
}
