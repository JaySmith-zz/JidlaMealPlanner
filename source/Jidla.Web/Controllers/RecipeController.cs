using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using Jidla.Web.Data;
using Jidla.Web.DataQueries;
using Jidla.Web.ViewModels;
using Magrathea.Interfaces;

namespace Jidla.Web.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IRepository _repository;

        public RecipeController(IRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            var recipes = _repository.Find(new RecipesByUserNameQuery(User.Identity.Name));
            var recipeViewModels = Mapper.Map<IEnumerable<RecipeViewModel>>(recipes);

            return View(recipeViewModels);
        }

        public ActionResult Create()
        {
            var model = new RecipeViewModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(RecipeViewModel recipeViewModel)
        {
            // Map View Model to Recipe
            var recipe = Mapper.Map<Recipe>(recipeViewModel);
            recipe.UserId = User.Identity.Name;

            _repository.Context.Add(recipe);
            _repository.Context.Commit();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var recipe = _repository.Find(new RecipeByIdQuery(id));
            var recipeViewModel = Mapper.Map<RecipeViewModel>(recipe);

            return View(recipeViewModel);
        }

        [HttpPost]
        public ActionResult Edit(RecipeViewModel recipeViewModel)
        {
            var recipe = _repository.Find(new RecipeByIdQuery(recipeViewModel.Id));
            Mapper.Map(recipeViewModel, recipe);
            _repository.Context.Commit();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var recipe = _repository.Find(new RecipeByIdQuery(id));
            _repository.Context.Remove(recipe);
            _repository.Context.Commit();

            return RedirectToAction("Index");
        }
    }
}