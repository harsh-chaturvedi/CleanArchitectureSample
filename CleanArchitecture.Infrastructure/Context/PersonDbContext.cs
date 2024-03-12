using CleanArchitecture.Domain;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure;

public class PersonDbContext : DbContext
{
    public PersonDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Person> Person { get; set; }
}
