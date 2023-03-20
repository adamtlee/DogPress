using System;
using System.ComponentModel.DataAnnotations;

namespace DogPress.Data.Models
{
    public class Breed
    {
        [Key, Required]
        public int Id { get; set; }
        public string ?Name { get; set; }
        public string ?Origin { get; set; }
        public int Lifespan { get; set; }
        public ActiveLevel ActiveLevel { get; set; }
    }
}
