using DogPress.Data.Models;

namespace DogPress.Services.DogService
{
    public interface IDogService
    {
        List<Dog> CreateDog(Dog dog, List<Dog> dogs);
    }
}