using Microsoft.EntityFrameworkCore;
using Qinshft.Movies.DataAccess.Interfaces;
using Qinshift.Movies.DomainModels;

namespace Qinshft.Movies.DataAccess.Implementation
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MovieRentDbContext _ctx;
        private DbSet<T> _table;

        public Repository(MovieRentDbContext ctx)
        {
            _ctx = ctx;
            _table = ctx.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _table.ToList();
        }

        public T GetById(int id)
        {
            return _table.SingleOrDefault(x => x.Id == id);
        }

        public int Add(T entity)
        {
            _table.Add(entity);
            return _ctx.SaveChanges();
        }

        public int Update(T entity)
        {
            T index = _table.SingleOrDefault(e => e.Id == entity.Id);
            if (index != null)
            {
                _table.Update(entity);
            }
            return _ctx.SaveChanges();
        }

        public int Remove(int id)
        {
            T index = _table.SingleOrDefault(e => e.Id == id);
            if (index != null)
            {
                _table.Remove(index);
            }
            return _ctx.SaveChanges();
        }
    }
}
