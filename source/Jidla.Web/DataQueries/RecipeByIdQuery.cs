using System.Linq;
using Jidla.Web.Data;
using Magrathea;

namespace Jidla.Web.DataQueries
{
    public class RecipeByIdQuery : Scalar<Recipe>
    {
        public RecipeByIdQuery(int id)
        {
            ContextQuery = c => c.AsQueryable<Recipe>().FirstOrDefault(x => x.Id == id);
        }
    }
}