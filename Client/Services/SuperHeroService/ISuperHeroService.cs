global using BlazorApp1.Shared;

namespace BlazorApp1.Client.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        List<SuperHero> SuperHeroes { get; set; }

        Task GetSuperHeroes();
    }
}
