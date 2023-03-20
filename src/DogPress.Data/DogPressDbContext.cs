using System;
using DogPress.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DogPress.Data
{
	public class DogPressDbContext : DbContext
	{
		public DogPressDbContext(DbContextOptions<DogPressDbContext> options)
			: base(options)
		{

		}

		public DbSet<Dog> Dogs { get; set; }
		public DbSet<Breed> Breeds { get; set; }
		public DbSet<Shelter> Shelters { get; set; }
	}
}

