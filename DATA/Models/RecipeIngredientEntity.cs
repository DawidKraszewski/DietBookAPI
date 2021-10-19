using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Models
{
    public class RecipeIngredientEntity : IEntity
    {
        [Key]
        public Guid Id { get; set; }

        public RecipeEntity Recipe { get; set; }

        public Guid RecipeEntityId { get; set; }

        public IngredientEntity Ingredient { get; set; }

        public Guid IngredientEntityId { get; set; }

        [Column(TypeName = "float(8,3)")]
        public Nullable<float> Quantity { get; set; }

        public UnitEntity Unit { get; set; }

        public Guid UnitEntityId { get; set; }

    }
}
