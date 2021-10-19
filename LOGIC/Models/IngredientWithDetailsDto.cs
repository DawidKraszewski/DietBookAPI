using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Models
{
    public class IngredientWithDetailsDto : IngredientDto
    {
        public List<RecipeDto> IngredientRecipes { get; set; } = new();

    }
}
