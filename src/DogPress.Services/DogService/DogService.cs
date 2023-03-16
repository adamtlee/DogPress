using System;
using DogPress.Data.Models;

namespace DogPress.Services.DogService
{
    public class DogService : IDogService
    {
        public DogService()
        {
        }

        /// <summary>
        /// retrieves all dogs in a List.
        /// </summary>
        /// <returns></returns>
        public List<Dog> GetDogs()
        {
            var dogs = new Dog();
            var allDogs = dogs.AllDogs();

            Console.WriteLine($"retrieved {allDogs.Count()} dogs.");
            return allDogs;
        }

        /// <summary>
        /// Creates a new Dog object and pushes it to a List<Dog>
        /// </summary>
        /// <param name="dog"></param>
        /// <param name="dogs"></param>
        /// <returns></returns>
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

        /// <summary>
        /// retrieves a dog by the Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Dog GetDogById(int Id)
        {
            try
            {
                var dogs = GetDogs();
                foreach (var dog in dogs)
                {
                    if (dog.Id == Id)
                    {
                        return dog;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex}");
            }
            
        }

        /// <summary>
        /// Deletes a dog from the List by and Id
        /// </summary>
        /// <param name="Id"></param>
        public void DeleteDogById(int Id)
        {
            var dogs = GetDogs();

            foreach(var dog in dogs)
            {
                Console.WriteLine($"Id: {dog.Id} | Name: {dog.FirstName} {dog.LastName} ");

                if (dog.Id == Id)
                {
                    dogs.Remove(dog);
                    Console.WriteLine("Removed dog from the list");
                    foreach (var d in dogs)
                    {
                        Console.WriteLine("Dogs Remaining: ");
                        Console.WriteLine($"Id: {d.Id} | Name: {d.FirstName} {d.LastName} ");
                    }

                    break; 
                }

            }

            
        }
    }
}

