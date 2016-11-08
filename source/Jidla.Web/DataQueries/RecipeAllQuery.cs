using System.Linq;
using Jidla.Web.Data;
using Magrathea;

namespace Jidla.Web.DataQueries
{
    public class RecipeAllQuery : Query<Recipe>
    {
        public RecipeAllQuery()
        {
            ContextQuery = c => c.AsQueryable<Recipe>();
        }
    }
}