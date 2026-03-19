using Domain.Entities;

namespace Application.Interfaces
{
    // ESTO ES CLAVE EN CLEAN ARCHITECTURE
    // La Application define el contrato, no la implementación
    public interface ICharacterRepository
    {
        Task<IEnumerable<Character>> GetAllAsync();

        Task<Character?> GetByIdAsync(int id);

        Task AddAsync(Character character);

        void Update(Character character);

        void Delete(Character character);

    }
}
