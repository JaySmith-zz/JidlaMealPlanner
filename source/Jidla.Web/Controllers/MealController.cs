using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Jidla.Data;
using Jidla.Infrastructure.DataQueries;
using Jidla.Web.ViewModels;
using Magrathea.Interfaces;

namespace Jidla.Web.Controllers
{
    public class MealController : Controller
    {
        private readonly IRepository _repository;

        public MealController(IRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            var meals = _repository.Find(new MealsByUserNameQuery(User.Identity.Name));
            var mealViewModels = Mapper.Map<IEnumerable<MealViewModel>>(meals);

            return View(mealViewModels);
        }

        public ActionResult Create()
        {
            var model = new MealViewModel();
            var availableRecipes = _repository.Find(new RecipesByUserNameQuery(User.Identity.Name));
            model.AvailableRecipes = Mapper.Map<IEnumerable<Recipe>, IEnumerable<RecipeViewModel>>(availableRecipes);

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(MealViewModel model)
        {
            return RedirectToAction("Index");
        }

        public IEnumerable<int> getSelectedIds(MealViewModel model)
        {
            // Return an Enumerable containing the Id's of the selected people:
            return (from p in model.AvailableRecipes where p.IsSelected select p.Id).ToList();
        }
    }
}