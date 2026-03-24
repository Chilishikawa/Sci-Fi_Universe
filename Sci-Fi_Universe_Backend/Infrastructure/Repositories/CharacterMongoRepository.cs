using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class CharacterMongoRepository : ICharacterRepository
    {
        private readonly IMongoCollection<Character> _collection;

        public  CharacterMongoRepository(IOptions<MongoDbSettings> settings)
        {
            var mongoClient = new MongoClient(settings.Value.ConnectionString);
            var database = mongoClient.GetDatabase(settings.Value.DatabaseName);

            _collection = database.GetCollection<Character>(settings.Value.Characters);
        }

        public async Task<IEnumerable<Character>> GetAllAsync()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task<Character?> GetByIdAsync(int id)
        {
            return await _collection.Find(p => p.Id == id.ToString()).FirstOrDefaultAsync(); ;
        }

        public async Task AddAsync(Character character)
        {
            await _collection.InsertOneAsync(character);
        }

        public void Update(Character character)
        {
            _collection.ReplaceOne(p => p.Id == character.Id, character);
        }

        public void Delete(Character character)
        {
            _collection.DeleteOne(p => p.Id == character.Id);
        }
    }
}
