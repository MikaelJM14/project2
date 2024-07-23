﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotoApp.Components.CsvReader.Extentions;
using Project2.CSV.Models;

namespace Project2.CSV
{
    public class Csvread : ICsvread
    {
        public List<Car> Cars(string filepath)
        {
            if (!File.Exists(filepath))
            {
                return new List<Car>();
            }

            var cars =
                File.ReadAllLines(filepath)
                .Skip(1)
                .Where(x => x.Length > 1)
                .ToCar();

            return cars.ToList();
        }

        public List<Manufacturer> Manufacturers(string filepath)
        {
            if (!File.Exists(filepath))
            {
                return new List<Manufacturer>();
            }

            var manufacturers =
                File.ReadAllLines(filepath)
                .Where(x => x.Length > 1)
                .Select(x =>
                {
                    var columns = x.Split(',');
                    return new Manufacturer()
                    {
                        Name = columns[0],
                        Country = columns[1],
                        Year = int.Parse(columns[2])
                    };
                });

            return manufacturers.ToList();
        }
    }
}
