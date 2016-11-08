using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Jidla.Web.Data
{
    public class JidlaContext : DbContext
    {
        public JidlaContext() : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<MealPlan> MealPlans { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}