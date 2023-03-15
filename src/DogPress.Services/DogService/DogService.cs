using System;
using DogPress.Data.Models;

namespace DogPress.Services.DogService
{
    public class DogService : IDogService
    {
        public DogService()
        {
        }

        public List<Dog> CreateDog(Dog dog, List<Dog> dogs)
        {

            try
            {
                var newDog = new Dog()
                {
                    Id = dog.Id,
                    FirstName = dog.FirstName,
                    LastName = dog.LastName,
                    Breed = new Breed()
                    {
                        Id = dog.Id,
                        Name = dog.Breed.Name,
                        ActiveLevel = dog.Breed.ActiveLevel,
                        Lifespan = dog.Breed.Lifespan,
                        Origin = dog.Breed.Origin,
                    },
                    Age = dog.Age,

                };
                dogs.Add(newDog);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An Error Occured: {ex}");
            }

            return dogs;

        }
    }
}

