using Microsoft.EntityFrameworkCore;
using Weather.API.Weather.Data;
using Weather.API.Weather.Models;
using Weather.API.Weather.Services.Interfaces;

namespace Weather.API.Weather.Services.Implementations
{
    public class WeatherService : IWeatherService
    {
        private readonly WeatherApiDbContext _context;

        public WeatherService(WeatherApiDbContext context)
        {
            _context = context;

        }

        public async Task<Weathers> AddWeather(Weathers weathers)
        {
            var weather = new Weathers
            {
                Id = weathers.Id,
                Date = DateTime.Now,
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            };
            _context.Weathers.Add(weather);

            bool res = await _context.SaveChangesAsync() > 0;
            if(!res)
                return null;
            return weather;
        }

        public async Task<List<Weathers>> GetAllWeathers()
        {
            var weathers = await _context.Weathers.ToListAsync();
            if (weathers.Count < 1)
                return default;
            return weathers;
        }

        public async Task<Weathers> GetWeatherById(int id)
        {
            var weather = await _context.Weathers.FirstOrDefaultAsync(x => x.Id == id);
            if (weather == null)
                return default;
            return weather;
        }
        private static readonly string[] Summaries = new[]
            {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };
    }
}
