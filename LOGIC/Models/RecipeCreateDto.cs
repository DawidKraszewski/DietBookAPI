using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Models
{
    public class RecipeCreateDto :IDto
    {
        public string Name { get; set; }

        public string Author { get; set; }

        public Guid Id { get; set; }

        public IFormFile Photo { get; set; }

        public DateTime CreatedDate { get; set; }

        public List<IngredientDto> RecipeIngredients { get; set; }

        public List<string> Steps { get; set; }
    }
}
