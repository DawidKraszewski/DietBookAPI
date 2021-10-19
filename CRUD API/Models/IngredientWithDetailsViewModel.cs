using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_API.Models
{
    public class IngredientWithDetailsViewModel : IngredientViewModel
    {
        public List<RecipeViewModel> IngredientRecipes { get; set; } = new();
    }
}
