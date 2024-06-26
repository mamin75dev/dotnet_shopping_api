using System.Linq.Expressions;

namespace ShoppingApi.Infrastructure.Interfaces;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetById(int id);
    Task<IEnumerable<T>> GetAll();
    Task<IEnumerable<T>> Search(Expression<Func<T, bool>> predicate);
    Task Add(T entity);
    void Delete(T entity);
    void Update(T entity);

    IEnumerable<T> GetMany(Func<T, bool> where);
}