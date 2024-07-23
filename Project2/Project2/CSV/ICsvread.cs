using Project2.CSV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Project2.CSV
{
    public interface ICsvread
    {
        List<Car> Cars(string filepath);

        List<Manufacturer> Manufacturers(string filepath);
    }
}
