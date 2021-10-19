using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Models
{
    public interface IDto<T>
    {
        T Id { get; set; }
    }
}
