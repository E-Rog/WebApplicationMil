namespace WebApplicationMil.Helpers;

using Microsoft.EntityFrameworkCore;
using WebApplicationMil.Entities;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        //in memory db
        options.UseInMemoryDatabase("TestDb");
    }

    public DbSet<User> Users { get; set; }
}