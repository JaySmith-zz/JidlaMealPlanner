using System.Linq;
using Jidla.Data;
using Magrathea;

namespace Jidla.Infrastructure.DataQueries
{
    public class RecipesByUserNameQuery : Query<Recipe>
    {
        public RecipesByUserNameQuery(string userId)
        {
            ContextQuery = c => c.AsQueryable<Recipe>().Where(x => x.UserId == userId);
        }
    }
}