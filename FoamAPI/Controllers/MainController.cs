using FoamAPI.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoamAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MainController : Controller
    {
        private readonly ILogger<MainController> _logger;
        private readonly FoamDbContext _foamDbContext;


        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public MainController(ILogger<MainController> logger, FoamDbContext foamDbContext)
        {
            _logger = logger;
            _foamDbContext = foamDbContext;
        }
        

        [HttpGet(template: "get")]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
