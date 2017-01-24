using Jidla.Data;
using Magrathea;

namespace Jidla.Infrastructure.DataQueries
{
    public class RecipeAllQuery : Query<Recipe>
    {
        public RecipeAllQuery()
        {
            ContextQuery = c => c.AsQueryable<Recipe>();
        }
    }
}