using Weather.API.Weather.Models;
using Weather.API.Weather.Models.DTOS;

namespace Weather.API.Weather.Services.Interfaces
{
    public interface IWeatherService
    {
        Task <List<Weathers>> GetAllWeathers();
        Task<Weathers> GetWeatherById(int id);
        Task<Weathers> AddWeather(AddWeatherDto weathers);
        Task<Weathers> UpdateWeather(int id, AddWeatherDto weathers);
        Task<bool> DeleteWeather(int id);
    }
}
