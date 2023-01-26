using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Weather.API.Weather.Models;
using Weather.API.Weather.Services.Interfaces;

namespace Weather.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weather;
        private readonly ILogger<WeatherController> _logger;

        public WeatherController(ILogger<WeatherController> logger, IWeatherService weather)
        {
            _weather = weather;
            _logger = logger;
        }

        [HttpGet("get-all-weather")]
        [Authorize]
        public async Task<IActionResult> GetAllWeather()
        {
            var result = await _weather.GetAllWeathers();
            if(result.Count() > 0) 
                return Ok(result);
            return NotFound();
        }
        [HttpGet("get-weather-by-id/{id}")]
        [Authorize]
        public async Task<IActionResult> GetAllWeather(int id)
        {
            var result = await _weather.GetWeatherById(id);
            if (result != null)
                return Ok(result);
            return NotFound();
        }

    }
}