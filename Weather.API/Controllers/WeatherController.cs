using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Weather.API.Weather.Models;
using Weather.API.Weather.Models.DTOS;
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
        [Authorize(Roles = "Administrator, User")]
        public async Task<IActionResult> GetAllWeather()
        {
            var result = await _weather.GetAllWeathers();
            if(result.Count() > 0) 
                return Ok(result);
            return NotFound();
        }
        [HttpGet("get-weather-by-id/{id}")]
        [Authorize(Roles = "Administrator, User")]
        public async Task<IActionResult> GetAllWeather(int id)
        {
            var result = await _weather.GetWeatherById(id);
            if (result != null)
                return Ok(result);
            return NotFound();
        }
        [HttpPost("add-weather")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> AddWeather([FromBody] AddWeatherDto weathers)
        {
            if (!ModelState.IsValid)
                return BadRequest("missing field");
            var result = await _weather.AddWeather(weathers);
            if (result == null) 
                return BadRequest("cannot add weather");
            return Ok(result);
        }
        [HttpPatch("update-weather/{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> UpdateWeather(int id, [FromBody] AddWeatherDto weathers)
        {
            var result = await _weather.UpdateWeather(id, weathers);
            if (result == null)
                return BadRequest("cannot update weather");
            return Ok(result);
        }
        [HttpDelete("remove-weather/{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> RemoveWeather(int id)
        {
            var result = await _weather.DeleteWeather(id);
            if (!result)
                return BadRequest("cannot delete weather");
            return Ok(result);
        }
    }
}