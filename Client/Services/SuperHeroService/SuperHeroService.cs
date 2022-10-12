using System.Net.Http.Json;

namespace BlazorApp1.Client.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private readonly HttpClient _http;

        public SuperHeroService(HttpClient http)
        {
            _http = http;
        }

        public List<SuperHero> SuperHeroes { get; set; } = new List<SuperHero>();

        public async Task GetSuperHeroes()
        {
            SuperHeroes = await _http.GetFromJsonAsync<List<SuperHero>>("api/superhero");
        }
    }
}
