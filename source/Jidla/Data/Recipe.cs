using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Jidla.Data
{
    public enum RecipeStatus
    {
        Available,
        Archived
    }

    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public RecipeStatus Status { get; set; }
        public int PrepTimeInMinutes { get; set; }
        public int CookTimeInMinutes { get; set; }
        public int ReadyInMinutes { get; set; }
        public int ServingSize { get; set; }
        public string PhotoUri { get; set; }
        public string Ingredients { get; set; }
        public string Directions { get; set; }
        
        public virtual ICollection<Meal> Meals { get; set; }

        public string UserId { get; set; }
    }
}