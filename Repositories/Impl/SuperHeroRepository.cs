﻿using Microsoft.EntityFrameworkCore;
using Net_8_LoginApp.Models;

namespace Net_8_LoginApp.Repositories.Impl

{
    public class SuperHeroRepository : ISuperHeroRepository
    {
        private readonly MyDbContext _dbContext;

        public SuperHeroRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<SuperHero>> GetAllHeroesAsync()
        {
            return await _dbContext.SuperHeroes.ToListAsync();
        }

        public async Task<SuperHero> GetHeroByIdAsync(int id)
        {
            return await _dbContext.SuperHeroes.FindAsync(id);
        }

        public async Task AddHeroAsync(SuperHero superHero)
        {
            _dbContext.SuperHeroes.Add(superHero);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateHeroAsync(SuperHero superHero)
        {
            var dbHero = await _dbContext.SuperHeroes.FindAsync(superHero.Id);
            if (dbHero != null)
            {
                dbHero.Name = superHero.Name;
                dbHero.FirstName = superHero.FirstName;
                dbHero.LastName = superHero.LastName;
                dbHero.Place = superHero.Place;
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteHeroAsync(int id)
        {
            var dbHero = await _dbContext.SuperHeroes.FindAsync(id);
            if (dbHero != null)
            {
                _dbContext.SuperHeroes.Remove(dbHero);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}