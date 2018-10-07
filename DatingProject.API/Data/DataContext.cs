using DatingProject.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingProject.API.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base 
        (options) {}

        public DbSet<Value> Values {get; set;} // table name in SQL

        public DbSet<User> Users {get; set;} //whenever new class is added we need to include it in db
    }
}