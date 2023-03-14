using System;
namespace DogPress.Api.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public Breed? Breed { get; set; }
    }
}
