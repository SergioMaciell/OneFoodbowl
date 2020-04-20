namespace OneFoodBowl.web.Data
{
    using Microsoft.EntityFrameworkCore;
using OneFoodBowl.web.Data.Entities;
    public class DataContext : DbContext
    {
       public DbSet<Gender> Genders { get; set; }
       public DbSet<Customer> Customers { get; set; }
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {

        }
    }
}
