namespace BlazorApp1.Server.Services.SUperHeroService
{
    public class SuperheroService : ISuperHeroService
    {
        private readonly DataContext _context;

        public SuperheroService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<SuperHero>> GetAll()
        {
            var heroes = await _context.SuperHeroes.ToListAsync();

            return heroes;
        }
    }
}
