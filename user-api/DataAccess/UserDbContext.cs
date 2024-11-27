namespace UserApi.DataAccess;

using Microsoft.EntityFrameworkCore;
using UserApi.Models.Entity;

public class UserDbContext(DbContextOptions<UserDbContext> options) : DbContext(options)
{
    public required DbSet<User> Users { get; set; }
}
