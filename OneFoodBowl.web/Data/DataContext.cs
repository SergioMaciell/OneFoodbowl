namespace OneFoodBowl.web.Data
{
    
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using OneFoodBowl.web.Data.Entities;
    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Nutritionist> Nutritionists { get; set; }
        public DbSet<RecipeDetail> RecipeDetails { get; set; }
        public DbSet<RecipeType> RecipeTypes { get; set; }
        public DbSet<CreatePlan> CreatePlans { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //public DbSet<OneFoodBowl.web.Data.Entities.RecipeDetail> RecipeDetail { get; set; }
    }
}
