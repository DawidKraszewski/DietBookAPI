using Autofac;
using LOGIC.Models;
using LOGIC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_API.Dependencies
{
    public class LogicDependency : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RecipeDto>().As<IDto>()
                .InstancePerDependency();

            builder.RegisterType<RecipeService>().As<IRecipeService>()
                .InstancePerDependency();

            builder.RegisterType<IngredientDto>().As<IDto>()
                .InstancePerDependency();

            builder.RegisterType<IngredientService>().As<IIngredientService>()
                .InstancePerDependency();

            builder.RegisterType<UnitDto>().As<IDto>()
                .InstancePerDependency();

            builder.RegisterType<UnitService>().As<IUnitService>()
                .InstancePerDependency();
        }
    }
}
