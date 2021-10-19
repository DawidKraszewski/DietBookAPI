using DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Repos
{
    public class UnitRepo : GenericRepo<UnitEntity>, IUnitRepo
    {
        public UnitRepo(DbContext context) : base(context)
        {

        }
    }
}
