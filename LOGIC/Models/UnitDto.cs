using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Models
{
    public class UnitDto : IDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
