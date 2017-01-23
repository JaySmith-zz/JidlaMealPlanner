using Jidla.Web.Data;

namespace Jidla.Web.ViewModels
{
    public class RecipeViewModel
    {
        public bool IsSelected { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public RecipeStatus Status { get; set; }
        public int PrepTimeInMinutes { get; set; }
        public int CookTimeInMinutes { get; set; }
        public int ServingSize { get; set; }
        public string PhotoUri { get; set; }
        public string Ingredients { get; set; }
        public string Directions { get; set; }

    }
}