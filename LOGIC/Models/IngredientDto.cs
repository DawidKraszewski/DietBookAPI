using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Models
{
    public class IngredientDto :IDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public UnitDto Unit { get; set; }

        public Nullable<float> Quantity { get; set; }

    }
}
