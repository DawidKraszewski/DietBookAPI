using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Models
{
    public class RecipeWithDetailsDto : RecipeDto
    {
        public List<IngredientDto> RecipeIngredients { get; set; }

        public List<string> Steps { get; set; }
    }
}
