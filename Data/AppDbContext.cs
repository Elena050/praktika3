using Microsoft.EntityFrameworkCore;
using paktika3.Models;

namespace practika3.Data;

public class AppDbContext : DbContext
{
   public DbSet<Student> Students => Set<Student>();

   public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
       modelBuilder.Entity<Student>().HasData(
           new Student { Id = 1, Login = "vanya123", Email = "vanya123@mail.com", FirstName = "Иван", MiddleName = "Иванович", LastName = "Иванов", Phone = "+71234567890", VkProfileLink = "http://vk.com/vanya123", CreatedAt = DateTimeOffset.Now},
           new Student { Id = 2, Login = "maria", Email = "maria@mail.com", FirstName = "Мария", MiddleName = "Ивановна", LastName = "Иванова", Phone = "+71234567899", VkProfileLink = "http://vk.com/vanya123", CreatedAt = DateTimeOffset.Now}
       );
   }
}

