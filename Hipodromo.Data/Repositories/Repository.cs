using System.Linq.Expressions;
using Hipodromo.Data.Context;
using Hipodromo.Domain.Entities;
using Hipodromo.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Hipodromo.Data.Repositories;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    private readonly HipodromoContext _context;

    public Repository(HipodromoContext context)
    {
        _context = context;
    }

    public IReadOnlyList<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }

    public IReadOnlyList<T> Find(Expression<Func<T, bool>> expression)
    {
        return _context.Set<T>().Where(expression).ToList();
    }

    public T? ById(Guid id)
    {
        throw new NotImplementedException();
    }

    public void Add(T entity)
    {
        throw new NotImplementedException();
    }

    public void AddRange(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }

    public void UpdateRange(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    public void Remove(T entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }
}