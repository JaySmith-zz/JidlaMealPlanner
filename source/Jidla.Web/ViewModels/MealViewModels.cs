using System.Collections.Generic;
using System.Web.Mvc;

namespace Jidla.Web.ViewModels
{
    public class MealViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<RecipeViewModel> AvailableRecipes { get; set; }
        
    }
}