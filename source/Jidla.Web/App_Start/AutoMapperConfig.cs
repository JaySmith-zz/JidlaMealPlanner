using System.Web.Mvc;
using Jidla.Data;
using Jidla.Web.ViewModels;

namespace Jidla.Web
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<RecipeViewModel, Recipe>();
                cfg.CreateMap<Recipe, RecipeViewModel>();

                cfg.CreateMap<MealViewModel, Meal>();
                cfg.CreateMap<Meal, MealViewModel>();

                cfg.CreateMap<Recipe, SelectListItem>()
                    .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Title));
            });
        }
    }
}