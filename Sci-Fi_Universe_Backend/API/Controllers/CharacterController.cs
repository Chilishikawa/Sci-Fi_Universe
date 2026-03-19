using Application.DTOs;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController] // Habilita validaciones automáticas 
    [Route("api/[controller]")] // api/character
    public class CharacterController : ControllerBase
    {
        private readonly CharacterService _service;

        public CharacterController(CharacterService service)
        {
            _service = service;
        }

        // GET: api/character
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result); //200
        }

        // GET: api/character/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            return Ok(result); //200
        }

        // POST: api/character
        [HttpPost]
        public async Task<IActionResult> Create(CharacterDTO dto)
        {
            await _service.AddAsync(dto);
            return Created("", dto); //201
        }

        // PUT: api/character/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CharacterDTO dto)
        {
            dto.Id = id;
            await _service.UpdateAsync(dto);
            return NoContent(); //204
        }

        // DELETE: api/character/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent(); //204
        }
    }
}