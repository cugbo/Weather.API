using Weather.API.Weather.Models;

namespace Weather.API.Weather.Services.Interfaces
{
    public interface IWeatherService
    {
        Task <List<Weathers>> GetAllWeathers();
        Task<Weathers> GetWeatherById(int id);
    }
}
