using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_API.Models
{
    public class IngredientViewModel
    {
        public string Id { get; set; }

        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        public UnitViewModel Unit { get; set; }

        public Nullable<float> Quantity { get; set; }

    }
}
