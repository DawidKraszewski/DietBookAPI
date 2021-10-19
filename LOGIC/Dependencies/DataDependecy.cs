using Autofac;
using DATA.Context;
using DATA.Repos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Dependencies
{
    public class DataDependency : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RecipeContext>().As<DbContext>();

            builder.RegisterType<RecipeRepo>().UsingConstructor(typeof(DbContext))
                .As<IRecipeRepo>()
                .InstancePerLifetimeScope();

            builder.RegisterType<IngredientRepo>().UsingConstructor(typeof(DbContext))
                .As<IIngredientRepo>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UnitRepo>().UsingConstructor(typeof(DbContext))
                .As<IUnitRepo>()
                .InstancePerLifetimeScope();
        }
    }
}
