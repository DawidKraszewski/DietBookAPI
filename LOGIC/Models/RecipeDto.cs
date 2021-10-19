using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Models
{
    public class RecipeDto : IDto
    {
        public string Name { get; set; }

        public string Author { get; set; }

        public Guid Id { get; set; }

        public string Photo { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}
