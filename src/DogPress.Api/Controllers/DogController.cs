using System;
using DogPress.Data.Models;
using DogPress.Services.DogService;
using Microsoft.AspNetCore.Mvc;

namespace DogPress.Backend.Controllers
{
    [ApiController]
    [Route("Dogs")]
    public class DogController : ControllerBase
    {
        private readonly ILogger<DogController> _logger;
        private readonly IDogService _dogService; 
        public DogController(ILogger<DogController> logger, IDogService dogService)
        {
            _logger = logger;
            _dogService = dogService;
        }

        [HttpPost(Name = "CreateDog")]
        public void CreateDog()
        {
            var dog = new Dog()
            {
                Id = 3, 
                FirstName = "Bowser",
                LastName = "Moe",
                Age = 2,
                Breed = new Breed()
                {
                    Id = 3,
                    Name = "Pitbull",
                    ActiveLevel = ActiveLevel.Low,
                    Lifespan = 14,
                    Origin = "USA"
                }
            };
            var getAllDogs = dog.AllDogs();

            var result =  _dogService.CreateDog(dog, getAllDogs);

            foreach(var r in result)
            {
                Console.WriteLine($"{r.Id} | {r.FirstName}");
                 
            }
        }

        [HttpGet(Name = "GetDogs")]
        public List<Dog> GetDogs()
        {
            var dogs = new Dog();
            var allDogs = dogs.AllDogs(); 

            _logger.LogInformation($"retrieved {allDogs.Count()} dogs.");
            return allDogs;
        }

    }
}
