using Net_8_LoginApp.Models;

namespace Net_8_LoginApp.Repositories
{
    public interface ISuperHeroRepository
    {
        Task<List<SuperHero>> GetAllHeroesAsync();
        Task<SuperHero> GetHeroByIdAsync(int id);
        Task AddHeroAsync(SuperHero superHero);
        Task UpdateHeroAsync(SuperHero superHero);
        Task DeleteHeroAsync(int id);
    }
}
