using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Data
{
    public interface IRepo<T> : IWriteRepo<T>,IReadRepo<T>
        where T : class, IEntity
    {
    }
}
