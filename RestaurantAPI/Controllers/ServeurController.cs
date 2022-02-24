using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantAPI.Controllers
{
    [ApiController]
    public class ServeurController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ServeurController> _logger;

        public ServeurController(ILogger<ServeurController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("weatherforecast")]
        public IEnumerable<WeatherForecast> GetWeather()
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

        [HttpGet]
        [Route("serveurs")]
        public IEnumerable<Serveur> GetServeurs()
        {
            var rng = new Random();
            var serveurs = Enumerable.Range(1, 3).Select(index => new Serveur { 
                commandes = Enumerable.Range(1, 2).Select(index => new Commande
                {
                    montant = rng.Next(0, 50) + rng.NextDouble(),
                    listePlat = Enumerable.Range(1, 3).Select(index => new Plat
                    {
                        Nom = "Plat" + index.ToString(),
                        Prix = rng.Next(0, 20) + rng.NextDouble()
                    }).ToArray()
                }).ToArray()
            })
            .ToArray();
            return serveurs;
        }

        [HttpGet]
        [Route("plats")]
        public IEnumerable<Plat> GetPlats()
        {
            var rng = new Random();
            var plats = Enumerable.Range(1, 3).Select(index => new Plat {
                Nom = "Plat" + index.ToString(),
                Prix = rng.Next(0, 20) + rng.NextDouble()
            })
            .ToArray();
            return plats;
        }
    }
}
