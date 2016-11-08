using System.Linq;
using Jidla.Web.Data;
using Magrathea;

namespace Jidla.Web.DataQueries
{
    public class MealsByUserNameQuery : Query<Meal>
    {
        public MealsByUserNameQuery(string userId)
        {
            ContextQuery = c => c.AsQueryable<Meal>().Where(x => x.UserId == userId);
        }
    }
}