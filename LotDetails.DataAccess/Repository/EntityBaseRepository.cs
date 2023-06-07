using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LotDetails.DataAccess.Repository
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class
    {
        private AppDBContext _appDBContext;

        public EntityBaseRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public IQueryable<T> All => GetAll();

        public IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            var query = _appDBContext.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = (DbSet<T>?)(query?.Include(includeProperty));
            }
            return query;
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _appDBContext.Set<T>().Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return _appDBContext.Set<T>();
        }

        //public T GetSingle(string primaryKey)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
