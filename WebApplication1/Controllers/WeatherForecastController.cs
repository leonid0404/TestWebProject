using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly List<WeatherForecast> WeatherForecasts = new List<WeatherForecast>();

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> GetWeatherForecast()
        {
            return WeatherForecasts;
        }

        [HttpPost]
        public void AddForecast(WeatherForecast weatherForecast)
        {
            WeatherForecasts.Add(weatherForecast);
        }

        [HttpPut]
        public void UpdateForecast(WeatherForecast weatherForecast)
        {
            var entity = WeatherForecasts.FirstOrDefault(x => x.Id == weatherForecast.Id);
            if (entity != null)
            {
                entity.TemperatureC = weatherForecast.TemperatureC;
                entity.Date = weatherForecast.Date;
                entity.Summary = weatherForecast.Summary;
            }
        }

        [HttpDelete]
        public void DeleteForecast(int id)
        {
            var entity = WeatherForecasts.FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                WeatherForecasts.Remove(entity);
            }
        }
    }
}