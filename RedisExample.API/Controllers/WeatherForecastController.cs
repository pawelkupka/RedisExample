using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RedisExample.API.Controllers
{
    using Extensions;
    using Services;

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WeatherForecastService _weatherForecastService;
        private readonly IDistributedCache _distributedCache;

        public WeatherForecastController(
            WeatherForecastService weatherForecastService,
            IDistributedCache distributedCache)
        {
            _weatherForecastService = weatherForecastService;
            _distributedCache = distributedCache;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            var cacheKey = "WeatherForecast";
            var forecast = await _distributedCache.GetRecordAsync<IEnumerable<WeatherForecast>>(cacheKey);
            if (forecast is null)
            {
                forecast = await _weatherForecastService.GetWeatherForecastAsync();
                await _distributedCache.SetRecordAsync(cacheKey, forecast);
            }
            return forecast;
        }
    }
}
