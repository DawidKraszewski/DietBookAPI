using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DATA.Repos;
using DATA.Models;
using AutoMapper;
using AgileObjects.ReadableExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace LOGIC.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepo recipeRepo;
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;

        public RecipeService(IMapper mapper, IRecipeRepo recipeRepo, IConfiguration configuration)
        {
            this.recipeRepo = recipeRepo;
            this.mapper = mapper;
            this.configuration = configuration;
        }

        public async Task<OperationResult<IList<RecipeDto>>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var result = await this.recipeRepo.GetAllAsync(cancellationToken);

            if (result == null)
            {
                return (ErrorResult)"No elements found";
            }

            var map = this.mapper.Map<IList<RecipeEntity>, IList<RecipeDto>>(result);

            return OperationResult.Success(map);
        }

        public async Task<OperationResult<RecipeDto>> CreateAsync(RecipeDto recipe, CancellationToken cancellationToken = default)
        {
            var map = this.mapper.Map<RecipeDto, RecipeEntity>(recipe);
            var result = await this.recipeRepo.CreateAsync(map, cancellationToken);

            if (result == null)
            {
                return ErrorResult.Error(nameof(recipe), "Failed to create.");
            }

            var resultMap = this.mapper.Map<RecipeDto>(result);

            return OperationResult.Success(resultMap);
        }

        public async Task<OperationResult<RecipeDto>> GetAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var result = await this.recipeRepo.GetAsync(id, cancellationToken);

            if (result == null)
            {
                return (ErrorResult)"Product not found";
            }

            var map = this.mapper.Map<RecipeDto>(result);

            return OperationResult.Success(map);
        }

        public async Task<OperationResult> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var result = await this.recipeRepo.DeleteAsync(id, cancellationToken);

            if (result == false)
            {
                return ErrorResult.Error(nameof(id), "Delete failed");
            }

            return OperationResult.Success(true);
        }

        public async Task<OperationResult> UpdateAsync(RecipeDto recipe, CancellationToken cancellationToken = default)
        {
            var map = this.mapper.Map<RecipeDto, RecipeEntity>(recipe);
            var result = await this.recipeRepo.UpdateAsync(map, cancellationToken);

            if (result == false)
            {
                return ErrorResult.Error(nameof(recipe), "Udpade failed");
            }

            return OperationResult.Success();
        }

        public async Task<OperationResult<RecipeWithDetailsDto>> GetRecipeWithDetails(Guid id, CancellationToken cancellationToken = default)
        {
            var result = await this.recipeRepo.GetRecipeWithDetails(id, cancellationToken);

            if (result == null)
            {
                return (ErrorResult)"No elements found";
            }

            var map = this.mapper.Map<RecipeEntity, RecipeWithDetailsDto>(result);

            if (map.RecipeIngredients == null)
            {
                map.RecipeIngredients = new List<IngredientDto>();
            }

            foreach (var item in result.RecipeIngredients)
            {

                var ingredient = new IngredientDto
                {
                    Id = item.IngredientEntityId,

                    Name = result.RecipeIngredients
                    .Where(s => s.Id == item.Id)
                    .Select(r => r.Ingredient.Name)
                    .FirstOrDefault(),

                    Unit = this.mapper.Map<UnitDto>(result.RecipeIngredients
                    .Where(s => s.Id == item.Id)
                    .Select(r => r.Unit)
                    .FirstOrDefault()),

                    Quantity = result.RecipeIngredients
                    .Where(s => s.Id == item.Id)
                    .Select(r => r.Quantity)
                    .FirstOrDefault(),
                };

                map.RecipeIngredients.Add(ingredient);

            };

            map.Steps = new List<string>();

            if (!(result.Steps == null))
                map.Steps.AddRange(new List<string>(result.Steps.Split(Environment.NewLine + "" + Environment.NewLine)));

            else
                map.Steps.Add(string.Empty);

            map.Photo = result.Photo;

            return OperationResult.Success(map);
        }

        public async Task<OperationResult<RecipeWithDetailsDto>> CreateWithDetailsAsync( RecipeCreateDto recipe, CancellationToken cancellationToken = default)
        {
            var map = this.mapper.Map<RecipeCreateDto, RecipeEntity>(recipe);

            var newSteps = String.Empty;

            if (recipe.Steps[0] != null)
            {
                if (recipe.Steps[0].Contains("\r\n"))
                { 
                    newSteps = recipe.Steps[0].Replace("\r\n", "\n"); 
                }
                else
                {
                    newSteps = recipe.Steps[0];
                }
            }

            map.Steps = newSteps;

            map.RecipeIngredients = new List<RecipeIngredientEntity>();

            foreach (var item in recipe.RecipeIngredients)
            {
                map.RecipeIngredients.Add(new RecipeIngredientEntity
                {
                    IngredientEntityId = item.Id,
                    RecipeEntityId = map.Id,
                    Quantity = item.Quantity,
                    UnitEntityId = (item.Unit.Id != Guid.Empty ? item.Unit.Id : new Guid("85194FB4-CF5E-4947-BE72-180D6052D58D")),
                    Id = Guid.NewGuid(),
                });
            };

            if (recipe.Photo != null)
            {
                var imageUploader = new ImageUploader(configuration);

                map.Photo = await imageUploader.Upload(recipe.Photo, recipe.Name);
            }

            var result = await this.recipeRepo.CreateAsync(map, cancellationToken);

            if (result == null)
            {
                return ErrorResult.Error(nameof(recipe), "Failed to create.");
            }

            var resultMap = this.GetRecipeWithDetails(result.Id, cancellationToken);

            return OperationResult.Success(resultMap.Result.Result);
        }

        public async Task<OperationResult> UpdateWithDetailsAsync(RecipeEditDto recipe, CancellationToken cancellationToken = default)
        {
            var map = this.mapper.Map<RecipeEditDto, RecipeEntity>(recipe);
            var newSteps = String.Empty;

            if (recipe.Steps[0].Contains("\r\n"))
            {
                newSteps = recipe.Steps[0].Replace("\r\n", "\n");
            }
            else
            {
                newSteps = recipe.Steps[0];
            }

            map.Steps = newSteps;

            map.RecipeIngredients = new List<RecipeIngredientEntity>();

            foreach (var item in recipe.RecipeIngredients)
            {
                map.RecipeIngredients.Add(new RecipeIngredientEntity
                {
                    IngredientEntityId = item.Id,
                    Recipe = map,
                    RecipeEntityId = map.Id,
                    Quantity = item.Quantity,
                    UnitEntityId = (item.Unit.Id != Guid.Empty ? item.Unit.Id : new Guid("85194FB4-CF5E-4947-BE72-180D6052D58D")),
                    Id = Guid.NewGuid(),
                });
            };

            if (recipe.NewPhoto != null)
            {
                var imageUploader = new ImageUploader(configuration);

                map.Photo = await imageUploader.Upload(recipe.NewPhoto, recipe.Name);
            }
            else
            {
                map.Photo = recipe.Photo;
            }


            var result = await this.recipeRepo.UpdateRecipeWithDetails(map, cancellationToken);

            if (result == null)
            {
                return ErrorResult.Error(nameof(recipe), "Udpade failed");
            }

            return OperationResult.Success();
        }
    }
}
