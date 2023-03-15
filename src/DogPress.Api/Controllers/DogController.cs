using System;
using DogPress.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace DogPress.Backend.Controllers
{
    [ApiController]
    [Route("Dogs")]
    public class DogController : ControllerBase
    {
        private readonly ILogger<DogController> _logger;
        public DogController(ILogger<DogController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetDogs")]
        public IEnumerable<Dog> GetDogs()
        {
            var dogs = new Dog();
            var allDogs = dogs.AllDogs(); 

            _logger.LogInformation($"retrieved {allDogs.Count()} dogs.");
            return allDogs;
        }

    }
}
