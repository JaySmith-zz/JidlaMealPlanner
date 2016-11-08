using System.Linq;
using Jidla.Web.Data;
using Magrathea;

namespace Jidla.Web.DataQueries
{
    public class RecipesByUserNameQuery : Query<Recipe>
    {
        public RecipesByUserNameQuery(string userId)
        {
            ContextQuery = c => c.AsQueryable<Recipe>().Where(x => x.UserId == userId);
        }
    }
}