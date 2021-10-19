using AutoMapper;
using CRUD_API.Models;
using LOGIC.Models;
using LOGIC.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CRUD_API.Controllers
{
    [Route("api/unit")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        
        private readonly IMapper mapper;
        private readonly IUnitService unitService;

        public UnitController(IUnitService unitService, IMapper mapper)
        {
            this.mapper = mapper;
            this.unitService = unitService;
        }

        //GET api/ingredient
        [HttpGet]
        public async Task<ActionResult> GetAllAsync(CancellationToken cancellationToken)
        {
            var operationResult = await this.unitService.GetAllAsync(cancellationToken);
            var productList = this.mapper.Map<IList<UnitDto>, IEnumerable<UnitViewModel>>(operationResult.Result);

            return Ok(productList);
        }
    }
}
