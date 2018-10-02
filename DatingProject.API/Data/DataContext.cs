using DatingProject.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingProject.API.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base 
        (options) {}

        public DbSet<Value> Values {get; set;} // table name in SQL
    }
}