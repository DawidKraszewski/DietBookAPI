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
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepo IngredientRepo;
        private readonly IMapper mapper;

        public IngredientService(IMapper mapper, IIngredientRepo IngredientRepo)
        {
            this.IngredientRepo = IngredientRepo;
            this.mapper = mapper;
        }

        public async Task<OperationResult<IList<IngredientDto>>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var result = await this.IngredientRepo.GetAllAsync(cancellationToken);

            if (result == null)
            {
                return (ErrorResult)"No elements found";
            }

            var map = this.mapper.Map<IList<IngredientEntity>, IList<IngredientDto>>(result);

            return OperationResult.Success(map);
        }

        public async Task<OperationResult<IngredientDto>> CreateAsync(IngredientDto Ingredient, CancellationToken cancellationToken = default)
        {
            var map = this.mapper.Map<IngredientDto, IngredientEntity>(Ingredient);
            var result = await this.IngredientRepo.CreateAsync(map, cancellationToken);

            if (result == null)
            {
                return ErrorResult.Error(nameof(Ingredient), "Failed to create.");
            }

            var resultMap = this.mapper.Map<IngredientDto>(result);

            return OperationResult.Success(resultMap);
        }

        public async Task<OperationResult<IngredientDto>> GetAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var result = await this.IngredientRepo.GetAsync(id, cancellationToken);

            if (result == null)
            {
                return (ErrorResult)"Product not found";
            }

            var map = this.mapper.Map<IngredientDto>(result);

            return OperationResult.Success(map);
        }

        public async Task<OperationResult> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var result = await this.IngredientRepo.DeleteAsync(id, cancellationToken);

            if (result == false)
            {
                return ErrorResult.Error(nameof(id), "Delete failed");
            }

            return OperationResult.Success(true);
        }

        public async Task<OperationResult> UpdateAsync(IngredientDto Ingredient, CancellationToken cancellationToken = default)
        {
            var map = this.mapper.Map<IngredientDto, IngredientEntity>(Ingredient);
            var result = await this.IngredientRepo.UpdateAsync(map, cancellationToken);

            if (result == false)
            {
                return ErrorResult.Error(nameof(Ingredient), "Udpade failed");
            }

            return OperationResult.Success();
        }

        public async Task<OperationResult<IList<IngredientDto>>> SearchForIngredients (string searchString, CancellationToken cancellationToken = default)
        {
            var result = await this.IngredientRepo.SearchForIngredients(searchString, cancellationToken);

            if (result == null)
            {
                return (ErrorResult)"No elements found";
            }

            var map = this.mapper.Map<IList<IngredientEntity>, IList<IngredientDto>>(result);

            return OperationResult.Success(map);
        }

        public async Task<OperationResult<IngredientWithDetailsDto>> GetIngredientWithDetails(Guid id, CancellationToken cancellationToken = default)
        {
            var result = await this.IngredientRepo.GetIngredientWithDetails(id, cancellationToken);

            if (result == null)
            {
                return (ErrorResult)"No elements found";
            }

            var map = this.mapper.Map<IngredientEntity, IngredientWithDetailsDto>(result);

            foreach (var item in result.RecipeIngredients)
            {

                var recipe = new RecipeDto
                {
                    Id = item.RecipeEntityId,
                    Name = result.RecipeIngredients
                    .Where(s => s.Id == item.Id)
                    .Select(r => r.Recipe.Name)
                    .FirstOrDefault(),

                };

                map.IngredientRecipes.Add(recipe);

            };

            return OperationResult.Success(map);
        }
    }
}
