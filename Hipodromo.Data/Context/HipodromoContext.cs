using System.Reflection;
using Hipodromo.Data.Context.Identity;
using Hipodromo.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hipodromo.Data.Context;

public class HipodromoContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
{
    public DbSet<Racecourse> Racecourses => Set<Racecourse>();
    public DbSet<Stable> Stables => Set<Stable>();
    public DbSet<Horse> Horses => Set<Horse>();

    public HipodromoContext(DbContextOptions<HipodromoContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}