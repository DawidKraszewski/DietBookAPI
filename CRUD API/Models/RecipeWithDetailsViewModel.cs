using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_API.Models
{
    public class RecipeWithDetailsViewModel : RecipeViewModel
    {
        public List<IngredientViewModel> RecipeIngredients { get; set; } = new();

        public List<string> Steps { get; set; } = new();

        
    }
}
