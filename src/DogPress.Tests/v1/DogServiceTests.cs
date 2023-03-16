using System;
using System.Collections.Generic;
using DogPress.Data.Models;
using DogPress.Services.DogService;
using Moq;

namespace DogPress.Tests.v1
{
	public class DogServiceTests
	{
		[Fact]
        public void GetDogs_ReturnsListOfDogs()
        {
            // Arrange
            var mockDog = new Mock<Dog>();
            var expectedDogs = new List<Dog>
        {
            new Dog { Id = 1, FirstName = "Fido", LastName = "Smith" },
            new Dog { Id = 2, FirstName = "Rover", LastName = "Johnson" },
            new Dog { Id = 3, FirstName = "Buddy", LastName = "Williams" }
        };
            mockDog.Setup(d => d.AllDogs()).Returns(expectedDogs);
            var dogService = new DogService(mockDog.Object);

            // Act
            var actualDogs = dogService.GetDogs();

            // Assert
            Assert.Equal(expectedDogs, actualDogs);
        }
    }
}

