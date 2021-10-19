using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CRUD_API.Models
{
    public class RecipeViewModel
    {
        public string Id { get; set; }

        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        public string Author { get; set; }

        public string Photo { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}
