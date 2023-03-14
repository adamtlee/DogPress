using System;
namespace DogPress.Api.Models
{
    public class Breed
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Origin { get; set; }
        public int Lifespan { get; set; }
        public ActiveLevel ActiveLevel { get; set; }
    }
}
