using System.Linq.Expressions;
using Hipodromo.Domain.Entities;

namespace Hipodromo.Domain.Interfaces.Repositories;

public interface IRepository<T> where T : BaseEntity
{
    IReadOnlyList<T> GetAll();
    IReadOnlyList<T> Find(Expression<Func<T, bool>> expression);
    T? ById(Guid id);
    void Add(T entity);
    void AddRange(IEnumerable<T> entities);
    void Update(T entity);
    void UpdateRange(IEnumerable<T> entities);
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entities);
}