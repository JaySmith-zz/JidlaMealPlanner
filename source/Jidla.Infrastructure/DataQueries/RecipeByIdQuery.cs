using System.Linq;
using Jidla.Data;
using Magrathea;

namespace Jidla.Infrastructure.DataQueries
{
    public class RecipeByIdQuery : Scalar<Recipe>
    {
        public RecipeByIdQuery(int id)
        {
            ContextQuery = c => c.AsQueryable<Recipe>().FirstOrDefault(x => x.Id == id);
        }
    }
}