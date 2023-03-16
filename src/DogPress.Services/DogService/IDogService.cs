using DogPress.Data.Models;

namespace DogPress.Services.DogService
{
    public interface IDogService
    {
        public List<Dog> CreateDog(Dog dog, List<Dog> dogs);
        public List<Dog> GetDogs();
        public Dog GetDogById(int Id);
        public void DeleteDogById(int Id);
    }
}