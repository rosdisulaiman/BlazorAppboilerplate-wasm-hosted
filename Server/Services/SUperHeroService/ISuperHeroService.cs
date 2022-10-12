namespace BlazorApp1.Server.Services.SUperHeroService
{
    public interface ISuperHeroService
    {
        Task<List<SuperHero>> GetAll();
    }
}
