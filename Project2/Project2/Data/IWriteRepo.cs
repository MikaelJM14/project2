using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Data
{
    public interface IWriteRepo<T> where T : class,IEntity
    {
        void Add(T item);

        void Remove(T item);

        void SaveChanes();
    }
}
