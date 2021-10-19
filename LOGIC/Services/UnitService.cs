using AutoMapper;
using DATA.Models;
using DATA.Repos;
using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LOGIC.Services
{
    public class UnitService : IUnitService
    {
        private readonly IUnitRepo unitRepo;
        private readonly IMapper mapper;

        public UnitService(IMapper mapper, IUnitRepo unitRepo)
        {
            this.unitRepo = unitRepo;
            this.mapper = mapper;
        }

        public Task<OperationResult<UnitDto>> CreateAsync(UnitDto model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<OperationResult<IList<UnitDto>>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var result = await this.unitRepo.GetAllAsync(cancellationToken);

            if (result == null)
            {
                return (ErrorResult)"No elements found";
            }

            var map = this.mapper.Map<IList<UnitEntity>, IList<UnitDto>>(result);

            return OperationResult.Success(map);
        }

        public Task<OperationResult<UnitDto>> GetAsync(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> UpdateAsync(UnitDto model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
