using LostArk.Api.Entities;
using LostArk.Api.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace LostArk.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            try
            {
                var user = await this.userRepository.GetUser(id);

                if (user == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(user);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving user from database");
            }
        }
    }
}
