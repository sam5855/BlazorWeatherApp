using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Api.Controllers
{
    [ApiController]
    [Route("api/weather")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Hot", "Sweltering"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetWeather()
        {
            var rng = new Random();
            var weather = new
            {
                Date = DateTime.Now.AddDays(rng.Next(1, 5)),
                TemperatureC = rng.Next(-10, 35),
                Summary = Summaries[rng.Next(Summaries.Length)]
            };
            return Ok(weather);
        }
    }
}
