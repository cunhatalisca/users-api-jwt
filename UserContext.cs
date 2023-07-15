using Microsoft.EntityFrameworkCore;

namespace UsersApi.models;

public class TodoContext : DbContext
{
    public UserContext(DbContextOptions<UserContext> options) : 
    base(options)
    {
    }

    public DbSet<User> Users { get; set; } = null!;
}