using System;
namespace DogPress.Data.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string ?FirstName { get; set; }
        public string ?LastName { get; set; }
        public int Age { get; set; }
        public Breed ?Breed { get; set; }

        // TODO: Temp Data Remove once db is implimented. 
        public List<Dog> AllDogs()
        {
            var dogs = new List<Dog>()
            {
                new Dog()
                {
                    Id = 1,
                    FirstName = "Smudge",
                    LastName = "Doe",
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
                    LastName = "Nu",
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
