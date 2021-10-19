using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Models
{
    public class RecipeEntity : IEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string Author { get; set; }

        public string Photo { get; set; }

        public List<RecipeIngredientEntity> RecipeIngredients { get; set; }

        public string Steps { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}
