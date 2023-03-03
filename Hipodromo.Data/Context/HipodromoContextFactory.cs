using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Hipodromo.Data.Context;

public class HipodromoContextFactory : IDesignTimeDbContextFactory<HipodromoContext>
{
    public HipodromoContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<HipodromoContext>();
        builder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Hipodromo;Trusted_Connection=True");

        return new HipodromoContext(builder.Options);
    }
}