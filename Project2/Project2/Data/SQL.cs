using Project2.CSV;
using Project2.CSV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Data
{
    public class SQL
    {
        private readonly Csvread _csvReader;
        private readonly DBContext _DbContext;

        public SQL(Csvread csvReader, DBContext motoAppDbContext)
        {
            _csvReader = csvReader;
            _DbContext = motoAppDbContext;
            _DbContext.Database.EnsureCreated();
        }

        public void Run()
        {
            //InsertData();
            //ReadAllCarsFromDb();
            ReadGroupedCarsFromDb();

            //var cayman = this.ReadFirst("Cayman");

            //_motoAppDbContext.Cars.Add(cayman);
            //_motoAppDbContext.SaveChanges();
            //cayman.Name = "Moj Shamochut";
            //_motoAppDbContext.SaveChanges();
        }

        //private Car? ReadFirst(string name)
        //{
        //    return _motoAppDbContext.Cars.FirstOrDefault(x => x.Name == name);
        //}

        public void ReadGroupedCarsFromDb()
        {
            var groups = _DbContext
                .Cars
                .GroupBy(x => x.Manufacturer)
                .Select(x => new
                {
                    Name = x.Key,
                    Cars = x.ToList()
                }).ToList();

            foreach (var group in groups)
            {
                Console.WriteLine(group.Name);
                Console.WriteLine("========");
                foreach (var car in group.Cars)
                {
                    Console.WriteLine($"\t{car.Name}: {car.Combined}");
                }
                Console.WriteLine();
            }
        }

        public void ReadAllCarsFromDb()
        {
            var carsFromDb = _DbContext.Cars.ToList();

            foreach (var carFromDb in carsFromDb)
            {
                Console.WriteLine($"\t{carFromDb.Name}: {carFromDb.Combined}");
            }
        }

        public void InsertData()
        {
            var cars = _csvReader.Cars("Resources\\files\\fuel.csv");

            foreach (var car in cars)
            {
                _DbContext.Cars.Add(new Car()
                {
                    Manufacturer = car.Manufacturer,
                    Name = car.Name,
                    Year = car.Year,
                    City = car.City,
                    Combined = car.Combined,
                    Cylinders = car.Cylinders,
                    Displace = car.Displace,
                    Highway = car.Highway,
                });
            }

            _DbContext.SaveChanges();
        }
    }
}
