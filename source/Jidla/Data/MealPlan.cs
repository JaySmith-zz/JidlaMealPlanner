using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Jidla.Data
{
    public class MealPlan
    {
        [Key]
        public int Id { get; set; }
        public DateTime MealDate { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
    }
}