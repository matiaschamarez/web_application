using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace web_application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        // POST api/<CharacterController>
        [HttpPost]
        public IActionResult PostCharacters([FromBody] List<Character> characters)
        {
            if (characters == null || characters.Count == 0)
            {
                return BadRequest("No characters provided.");
            }

            // Procesa la lista de personajes
            return Ok(characters);
        }

    }
}
