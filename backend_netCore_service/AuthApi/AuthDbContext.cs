using AuthApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthApi;

public class AuthDbContext : DbContext
{
    public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options) { }

    public DbSet<ApplicationUser> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var hasher = new Microsoft.AspNetCore.Identity.PasswordHasher<ApplicationUser>();

        // Seed users
        modelBuilder.Entity<ApplicationUser>().HasData(
            new ApplicationUser
            {
                Id = "1",
                Username = "admin@todo.dev",
                Role = "Admin",
                PasswordHash = hasher.HashPassword(new ApplicationUser { Username = "admin@todo.dev", Role = "Admin", Id = "1", PasswordHash = "" }, "ChangeMe123!"),
                FullName = "Admin User"
            },
            new ApplicationUser
            {
                Id = "2",
                Username = "user@todo.dev",
                Role = "User",
                PasswordHash = hasher.HashPassword(new ApplicationUser { Username = "user@todo.dev", Role = "User", Id = "2", PasswordHash = "" }, "ChangeMe123!"),
                FullName = "Regular User"
            }
        );
    }
}