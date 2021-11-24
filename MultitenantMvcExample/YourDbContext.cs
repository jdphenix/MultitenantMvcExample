using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers;

public class YourDbContext : DbContext
{
    public YourDbContext(DbContextOptions<YourDbContext> options) : base(options) {}
}