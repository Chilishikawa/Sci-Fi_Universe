using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    // ESTE ES EL CEREBRO DE LA APLICACIÓN
    // Aquí va toda la lógica de negocio, validaciones, etc. ( No en controllers.)
    public class CharacterService
    {
        private readonly ICharacterRepository _repository;

        // Inyección de dependencias (DI)
        public CharacterService(ICharacterRepository repository)
        {
            _repository = repository;
        }

        // GET ALL
        public async Task<IEnumerable<Character>> GetAllAsync()
        {
            var characters = await _repository.GetAllAsync();

            // Mapping Entity -> DTO
            return characters.Select(c => new Character
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description,
                Work = c.Work,
                BirthDate = c.BirthDate
            });
        }

        // GET BY ID
        public async Task<CharacterDTO> GetByIdAsync(int id)
        {
            var character = await _repository.GetByIdAsync(id);

            if (character == null)
                throw new Exception("Personaje no encontrado.");

            return new CharacterDTO
            {
                Id = character.Id,
                Name = character.Name,
                Description = character.Description,
                Work = character.Work,
                BirthDate = character.BirthDate
            };
        }

        // CREATE
        public async Task AddAsync(CharacterDTO dto)
        {
            var character = new Character
            {
                Name = dto.Name,
                Description = dto.Description,
                Work = dto.Work,
                BirthDate = dto.BirthDate
            };

            await _repository.AddAsync(character);
        }

        // UPDATE
        public async Task UpdateAsync(CharacterDTO dto)
        {
            var character = await _repository.GetByIdAsync(dto.Id);

            if (character == null)
                throw new Exception("Personaje no encontrado.");

            character.Name = dto.Name;
            character.Description = dto.Description;
            character.Work = dto.Work;
            character.BirthDate = dto.BirthDate;

            _repository.Update(character);
        }

        // DELETE
        public async Task DeleteAsync(int id)
        {
            var character = await _repository.GetByIdAsync(id);

            if (character == null)
                throw new Exception("Personaje no encontrado.");

            _repository.Delete(character);
        }
    }
}
