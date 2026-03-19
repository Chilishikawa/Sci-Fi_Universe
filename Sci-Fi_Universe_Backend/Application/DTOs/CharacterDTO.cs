using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    // DTO = Data Transfer Object
    // Se usa para comunicar capas (Evitar exponer entidades directamente)
    public class CharacterDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; }

        [Required]
        public string Work { get; set; }


        public DateTime BirthDate { get; set; }
    }
}
