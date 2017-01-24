using System.Linq;
using Jidla.Data;
using Magrathea;

namespace Jidla.Infrastructure.DataQueries
{
    public class MealsByUserNameQuery : Query<Meal>
    {
        public MealsByUserNameQuery(string userId)
        {
            ContextQuery = c => c.AsQueryable<Meal>().Where(x => x.UserId == userId);
        }
    }
}