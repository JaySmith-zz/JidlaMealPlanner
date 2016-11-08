using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Jidla.Web.Data
{
    public enum MealStatus
    {
        Available,
        Archived
    }

    public class Meal
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public MealStatus Status { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
        public virtual ICollection<MealPlan> MealPlans { get; set; }

        public string UserId { get; set; }
    }
}