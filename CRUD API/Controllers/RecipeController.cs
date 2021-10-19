using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LOGIC.Services;
using LOGIC.Models;
using CRUD_API.Models;
using System.Threading;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace CRUD_API.Controllers
{
    [Route("api/recipe")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IRecipeService recipeService;

        public RecipeController(IRecipeService recipeService, IMapper mapper)
        {
            this.mapper = mapper;
            this.recipeService = recipeService;
        }

        //GET api/recipe
        [HttpGet]
        public async Task<ActionResult> GetAllAsync(CancellationToken cancellationToken)
        {
            var operationResult = await this.recipeService.GetAllAsync(cancellationToken);
            var productList = this.mapper.Map<IList<RecipeDto>, IEnumerable<RecipeViewModel>>(operationResult.Result);

            return Ok(productList);
        }

        //GET api/recipe/{id}
        [HttpGet("{id}", Name = "GetRecipeAsync")]
        public async Task<ActionResult> GetRecipeAsync(string id, CancellationToken cancellationToken)
        {
            Guid guid;

            if (string.IsNullOrEmpty(id) || !Guid.TryParse(id, out guid))
            {
                return new BadRequestResult();
            }

            var operationResult = await this.recipeService.GetAsync(guid, cancellationToken);

            if (!operationResult.IsSuccessful)
            {
                return new NotFoundResult();
            }

            var recipeViewModel = this.mapper.Map<RecipeDto, RecipeViewModel>(operationResult.Result);

            return Ok(recipeViewModel);
        }

        //POST api/recipe
        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromForm] RecipeCreateViewModel recipeWithDetails, CancellationToken cancellationToken)
        {
            if (recipeWithDetails != null)
            {
                var recipe = this.mapper.Map<RecipeCreateViewModel, RecipeCreateDto>(recipeWithDetails);

                var operationResult = await this.recipeService.CreateWithDetailsAsync(recipe, cancellationToken);

                if (operationResult.IsSuccessful)
                {
                    return CreatedAtRoute(nameof(GetRecipeAsync), new { id = operationResult.Result.Id }, operationResult.Result);
                }
            }

            return BadRequest();
        }

        //DELETE api/recipe/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(string id, CancellationToken cancellationToken)
        {
            Guid guid;

            if (string.IsNullOrEmpty(id) || !Guid.TryParse(id, out guid))
            {
                return BadRequest();
            }

            var operationResult = await this.recipeService.DeleteAsync(guid, cancellationToken);

            if (!operationResult.IsSuccessful)
            {
                return NotFound();
            }

            return Ok();
        }

        //UPDATE api/recipe
        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromForm] RecipeEditViewModel recipe, CancellationToken cancellationToken)
        {
            if (recipe != null)
            {
                var recipeDto = this.mapper.Map<RecipeEditViewModel, RecipeEditDto>(recipe);
                var operationResult = await this.recipeService.UpdateWithDetailsAsync(recipeDto, cancellationToken);

                if (operationResult.IsSuccessful)
                {
                    return NoContent();
                }

                return NotFound();
            }

            return BadRequest();
        }

        //PATCH api/recipe/{id}
        [HttpPatch("{id}")]
        public async Task<ActionResult> PatchAsync (string id, JsonPatchDocument<RecipeDto> patchDoc, CancellationToken cancellationToken)
        {
            Guid guid;

            if (string.IsNullOrEmpty(id) || !Guid.TryParse(id, out guid))
            {
                return BadRequest();
            }

            var operationResult = await this.recipeService.GetAsync(guid, cancellationToken);

            if (operationResult ==null)
            {
                return NotFound();
            }

            var recipeViewModel = this.mapper.Map<RecipeDto>(operationResult.Result);

            patchDoc.ApplyTo(recipeViewModel, ModelState);
            
            if (!TryValidateModel(recipeViewModel))
            {
                return ValidationProblem(ModelState);
            }

            var result = this.mapper.Map<RecipeDto>(recipeViewModel);

            await this.recipeService.UpdateAsync(result, cancellationToken);

            return NoContent();
        }

        //GET api/recipe/ingredients/{id}
        [HttpGet, Route ("ingredients/{id}")]
        public async Task<ActionResult> GetRecipeWithDetails(Guid id, CancellationToken cancellationToken)
        {
            var operationResult = await this.recipeService.GetRecipeWithDetails(id, cancellationToken);
            var recipe = this.mapper.Map<RecipeWithDetailsDto, RecipeWithDetailsViewModel>(operationResult.Result);

            return Ok(recipe);
        }
    }
}
