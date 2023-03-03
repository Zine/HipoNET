using System.Linq.Expressions;
using Hipodromo.Data.Context;
using Hipodromo.Domain.Entities;
using Hipodromo.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Hipodromo.Data.Repositories;

public class RacecourseRepository : IRacecourseRepository
{
    private readonly HipodromoContext _context;
    
    public RacecourseRepository(HipodromoContext context)
    {
        _context = context;
    }

    public IReadOnlyList<Racecourse> GetAll()
    {
        return _context.Set<Racecourse>().ToList();
    }

    public IReadOnlyList<Racecourse> Find(Expression<Func<Racecourse, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Racecourse? ById(Guid id)
    {
        throw new NotImplementedException();
    }

    public void Add(Racecourse entity)
    {
        throw new NotImplementedException();
    }

    public void AddRange(IEnumerable<Racecourse> entities)
    {
        throw new NotImplementedException();
    }

    public void Update(Racecourse entity)
    {
        throw new NotImplementedException();
    }

    public void UpdateRange(IEnumerable<Racecourse> entities)
    {
        throw new NotImplementedException();
    }

    public void Remove(Racecourse entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<Racecourse> entities)
    {
        throw new NotImplementedException();
    }
}