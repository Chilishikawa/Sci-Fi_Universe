using AutoMapper;
using Domain.Entities;
using Application.DTOs;

namespace Application.Mappings
{ 
    // Aquí defines TODAS las conversiones
    public class MappingProfile : Profile

    {
        public MappingProfile()
        {
            // Entity -> DTO
            CreateMap<Character, CharacterDTO>();

            // DTO -> Entity
            CreateMap<CharacterDTO, Character>();
        }
    }
}
