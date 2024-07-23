using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Data
{
    public interface IReadRepo<out T> where T : class,IEntity
    {
        IEnumerable<T> GetAll();
        T GetId(int id);
    }
}
