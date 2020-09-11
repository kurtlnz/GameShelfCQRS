using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GameShelf.Domain.Dtos;
using GameShelf.Domain.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace GameShelf.Domain.Services.Game
{
    public class GameService : IGameService
    {
        private readonly DataContext _db;
        public GameService(DataContext db)
        {
            _db = db;
        }
        
        public async Task<List<Models.Game>> GetGamesAsync()
        {
            return await _db.Games.ToListAsync();
        }
        
        public async Task<Models.Game> GetGameAsync(Guid id)
        {
            var game = await _db.Games.SingleOrDefaultAsync(_ => _.Id == id);
            
            if (game == null)
                throw new ObjectNotFoundException($"Could not find game with id '{id}'");
            
            return game;
        }
        
        public async Task CreateGameAsync(CreateGame dto)
        {
            var game = new Models.Game()
            {
                Title = dto.Title,
                Year = dto.Year
            };
            
            await _db.Games.AddAsync(game);
            await _db.SaveChangesAsync();
        }
        
        public async Task UpdateGameAsync(UpdateGame dto)
        {
            var game = await _db.Games.SingleOrDefaultAsync(_ => _.Id == dto.Id);
            if (game == null)
                throw new ObjectNotFoundException($"Could not find game with id '{dto.Id}'");
            
            game.Title = dto.Title;
            game.Year = dto.Year;
            await _db.SaveChangesAsync();
        }
        
        public async Task DeleteGameAsync(Guid id)
        {
            var game = await _db.Games.SingleOrDefaultAsync(_ => _.Id == id);
            
            if (game == null)
                throw new ObjectNotFoundException($"Could not find game with id '{id}'");
            
            _db.Games.Remove(game);
            await _db.SaveChangesAsync();
        }
        
    }
}