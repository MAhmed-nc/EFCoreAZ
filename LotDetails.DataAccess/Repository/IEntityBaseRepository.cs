using System.Linq.Expressions;

namespace LotDetails.DataAccess.Repository
{
    public interface IEntityBaseRepository<T> where T : class
    {
        IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        IQueryable<T> All { get; }
        IQueryable<T> GetAll();
        //T GetSingle(string primaryKey);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
    }
}