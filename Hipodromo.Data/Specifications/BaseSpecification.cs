using System.Linq.Expressions;
using Hipodromo.Domain.Entities;
using Hipodromo.Domain.Interfaces.Repositories;

namespace Hipodromo.Data.Specifications;

public class BaseSpecification<T> : ISpecification<T>
{
    public Expression<Func<T, bool>> Criteria { get; }
    public List<Expression<Func<T, object>>> Includes { get; }
    public Expression<Func<T, object>> OrderBy { get; }
    public Expression<Func<T, object>> OrderByDescending { get; }
}