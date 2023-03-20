using System;
using System.ComponentModel.DataAnnotations;

namespace DogPress.Data.Models
{
    public class Shelter
    {
        [Key, Required]
        public int Id { get; set; }
        public string ?Name { get; set; }
        public string ?Address { get; set; }
    }
}
