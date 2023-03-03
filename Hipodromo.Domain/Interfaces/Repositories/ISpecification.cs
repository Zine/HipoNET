using System.Linq.Expressions;
using Hipodromo.Domain.Entities;

namespace Hipodromo.Domain.Interfaces.Repositories;

public interface ISpecification<T>
{
    Expression<Func<T, bool>> Criteria { get; }
    List<Expression<Func<T, object>>> Includes { get; }
    Expression<Func<T, object>> OrderBy { get; }
    Expression<Func<T, object>> OrderByDescending { get; }
}