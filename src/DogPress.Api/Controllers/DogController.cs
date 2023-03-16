using System;
using DogPress.Data.Models;
using DogPress.Services.DogService;
using Microsoft.AspNetCore.Mvc;

namespace DogPress.Backend.Controllers
{
    [ApiController]
    [Route("/api/v1/DogController")]
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

        [HttpGet]
        [Route("dogs")]
        public List<Dog> GetDogs()
        {
            var result = _dogService.GetDogs();
            return result;
        }

        [HttpGet]
        [Route("dogs/{Id}")]
        public Dog GetDog(int Id)
        {
            var result = _dogService.GetDogById(Id);
            return result;
        }

        [HttpDelete]
        [Route("dogs/{Id}")]
        public void DeleteDog(int Id)
        {
            try
            {
                _dogService.DeleteDogById(Id);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An Error Occured: {ex}"); 
            }
            
        }

    }
}
