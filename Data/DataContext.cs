using Microsoft.EntityFrameworkCore;
using apiDotnetOne.Models;

namespace apiDotnetOne.Data{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options){

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}