using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_API.Models
{
    public class RecipeEditViewModel
    {
        public string Id { get; set; }

        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        public string Author { get; set; }

        public string Photo { get; set; }

        public IFormFile NewPhoto { get; set; }

        public DateTime CreatedDate { get; set; }

        [ModelBinder(BinderType = typeof(FormDataJsonBinder))]
        public List<IngredientViewModel> RecipeIngredients { get; set; } = new();

        public List<string> Steps { get; set; } = new();
    }
}

