using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Data
{
    public class SqlRepo<T> : IRepo<T> where T : class, IEntity
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        private readonly Action<T> _itemAddedCallBack;

        public SqlRepo(DbContext dbContext, Action<T> itemAddedCallBack = null)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
            _itemAddedCallBack = itemAddedCallBack;
        }

        public event EventHandler<T> ItemAdded;

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetId(int id)
        {
            return _dbSet.Find(id);
        }

        public void Add(T item)
        {
            _dbSet.Add(item);
            _itemAddedCallBack?.Invoke(item);
            ItemAdded?.Invoke(this, item);
        }

        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }

        public void SaveChanes()
        {
            _dbContext.SaveChanges();
        }
    }
}
