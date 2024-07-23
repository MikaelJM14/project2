using Microsoft.EntityFrameworkCore;
using Project2.CSV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Data;

public class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> dbContextOptions)
    : base(dbContextOptions)
    {
    }

    public DbSet<Car> Cars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.LogTo(Console.WriteLine);
}