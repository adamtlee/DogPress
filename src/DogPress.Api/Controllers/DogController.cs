using System;
using DogPress.Api.Models;
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
            var dogs = new List<Dog>()
            {
                new Dog()
                {
                    Id = 1,
                    FirstName = "Smudge",
                    LastName = "Duan",
                    Age = 2,
                    Breed = new Breed()
                    {
                        Id = 1,
                        Name = "Jindo",
                        ActiveLevel = ActiveLevel.High,
                        Lifespan = 14,
                        Origin = "Korea"
                    }

                },
                    new Dog()
                {
                    Id = 2,
                    FirstName = "Gatsby",
                    LastName = "Lee",
                    Age = 2,
                    Breed = new Breed()
                    {
                        Id = 1,
                        Name = "German Shepherd",
                        ActiveLevel = ActiveLevel.High,
                        Lifespan = 14,
                        Origin = "Germany"
                    }
                }
            };

            return dogs;
        }

    }
}
