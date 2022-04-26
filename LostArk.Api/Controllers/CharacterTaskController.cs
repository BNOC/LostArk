using LostArk.Api.Entities;
using LostArk.Api.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LostArk.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterTaskController : ControllerBase
    {
        private readonly ICharacterTaskRepository characterTaskRepository;

        public CharacterTaskController(ICharacterTaskRepository characterTaskRepository)
        {
            this.characterTaskRepository = characterTaskRepository;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<CharacterTask>> GetCharacterTask(int id)
        {
            try
            {
                var characterTask = await this.characterTaskRepository.GetCharacterTask(id);

                if (characterTask == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(characterTask);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving characterTask from database");
            }
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCharacterTask([FromBody] CharacterTask characterTask, [FromRoute] int id)
        {
            await this.characterTaskRepository.UpdateCharacterTask(id, characterTask);
            return Ok();
        }


    }
}
