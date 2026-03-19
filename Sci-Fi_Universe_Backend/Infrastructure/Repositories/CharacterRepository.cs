using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    // IMPLEMENTACIÓN REAL del contrato
    public class CharacterRepository : ICharacterRepository
    {
        private readonly ApplicationDbContext _context;

        public CharacterRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Character>> GetAllAsync()
        {
            return await _context.Characters.ToListAsync();
        }

        public async Task<Character?> GetByIdAsync(int id)
        {
            return await _context.Characters.FindAsync(id);
        }

        public async Task AddAsync(Character character)
        {
            await _context.Characters.AddAsync(character);
            await _context.SaveChangesAsync();
        }

        public void Update(Character character)
        {
            _context.Characters.Update(character);
            _context.SaveChanges();
        }

        public void Delete(Character character)
        {
            _context.Characters.Remove(character);
            _context.SaveChanges();
        }
    }
}
