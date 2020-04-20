namespace OneFoodBowl.web.Data
{
    using Microsoft.EntityFrameworkCore;
using OneFoodBowl.web.Data.Entities;
    public class DataContext : DbContext
    {
        DbSet<Gender> Genders { get; set; }
        DbSet<Customer> Customers { get; set; }
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {

        }
    }
}
