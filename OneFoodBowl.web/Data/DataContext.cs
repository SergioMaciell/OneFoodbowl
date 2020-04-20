namespace OneFoodBowl.web.Data
{
    using Microsoft.EntityFrameworkCore;
using OneFoodBowl.web.Data.Entities;
    public class DataContext : DbContext
    {
       public DbSet<Gender> Genders { get; set; }
       public DbSet<Customer> Customers { get; set; }
        public DbSet<Nutritionist> Nutritionists { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeType> RecipeTypes { get; set; }
        public DbSet<CreatePlan> CreatePlans { get; set; }

        public DataContext(DbContextOptions<DataContext>options):base(options)
        {

        }
    }
}
