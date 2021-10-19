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

namespace CRUD_API.Controllers
{
    [Route("api/ingredient")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IIngredientService ingredientService;

        public IngredientController(IIngredientService ingredientService, IMapper mapper)
        {
            this.mapper = mapper;
            this.ingredientService = ingredientService;
        }

        //GET api/ingredient
        [HttpGet]
        public async Task<ActionResult> GetAllAsync(CancellationToken cancellationToken)
        {
            var operationResult = await this.ingredientService.GetAllAsync(cancellationToken);
            var ingredientList = this.mapper.Map<IList<IngredientDto>, IEnumerable<IngredientViewModel>>(operationResult.Result);

            return Ok(ingredientList);
        }

        //GET api/ingredient/{id}
        [HttpGet("{id}", Name = "GetIngredientAsync")]
        public async Task<ActionResult> GetIngredientAsync(string id, CancellationToken cancellationToken)
        {

            Guid guid;

            if (string.IsNullOrEmpty(id) || !Guid.TryParse(id, out guid))
            {
                return new BadRequestResult();
            }

            var operationResult = await this.ingredientService.GetAsync(guid, cancellationToken);

            if (!operationResult.IsSuccessful)
            {
                return new NotFoundResult();
            }

            var ingredientViewModel = this.mapper.Map<IngredientDto, IngredientViewModel>(operationResult.Result);

            return Ok(ingredientViewModel);
        }

        //POST api/ingredient
        [HttpPost]
        public async Task<ActionResult> CreateAsync(IngredientViewModel ingredientViewModel, CancellationToken cancellationToken)
        {
            if (ingredientViewModel != null)
            {
                var ingredient = this.mapper.Map<IngredientViewModel, IngredientDto>(ingredientViewModel);

                var operationResult = await this.ingredientService.CreateAsync(ingredient, cancellationToken);

                if (operationResult.IsSuccessful)
                {
                    return Ok();
                }
            }

            return BadRequest();
        }

        //DELETE api/ingredient/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(string id, CancellationToken cancellationToken)
        {
            Guid guid;

            if (string.IsNullOrEmpty(id) || !Guid.TryParse(id, out guid))
            {
                return BadRequest();
            }

            var operationResult = await this.ingredientService.DeleteAsync(guid, cancellationToken);

            if (!operationResult.IsSuccessful)
            {
                return NotFound();
            }

            return Ok();
        }

        //UPDATE api/ingredient
        [HttpPut]
        public async Task<ActionResult> UpdateAsync(IngredientViewModel ingredientViewModel, CancellationToken cancellationToken)
        {
            if (ingredientViewModel != null)
            {
                var ingredient = this.mapper.Map<IngredientViewModel, IngredientDto>(ingredientViewModel);
                var operationResult = await this.ingredientService.UpdateAsync(ingredient, cancellationToken);

                if (operationResult.IsSuccessful)
                {
                    return NoContent();
                }

                return NotFound();
            }

            return BadRequest();
        }

        //PATCH api/ingredient/{id}
        [HttpPatch("{id}")]
        public async Task<ActionResult> PatchAsync(string id, JsonPatchDocument<IngredientDto> patchDoc, CancellationToken cancellationToken)
        {
            Guid guid;

            if (string.IsNullOrEmpty(id) || !Guid.TryParse(id, out guid))
            {
                return BadRequest();
            }

            var operationResult = await this.ingredientService.GetAsync(guid, cancellationToken);

            if (operationResult == null)
            {
                return NotFound();
            }

            var ingredientViewModel = this.mapper.Map<IngredientDto>(operationResult.Result);

            patchDoc.ApplyTo(ingredientViewModel, ModelState);

            if (!TryValidateModel(ingredientViewModel))
            {
                return ValidationProblem(ModelState);
            }

            var result = this.mapper.Map<IngredientDto>(ingredientViewModel);

            await this.ingredientService.UpdateAsync(result, cancellationToken);

            return NoContent();
        }

        //GEt api/ingredient/search
        [HttpGet, Route("search")]
        public async Task<ActionResult> SearchForIngredients(string searchString, CancellationToken cancellationToken)
        {
            var operationResult = await this.ingredientService.SearchForIngredients(searchString, cancellationToken);
            var ingredientList = this.mapper.Map<IList<IngredientDto>, IEnumerable<IngredientViewModel>>(operationResult.Result);

            return Ok(ingredientList);
        }

        //GEt api/ingredient/recipes/{id}
        [HttpGet, Route("recipes/{id}")]
        public async Task<ActionResult> GetIngredientWithDetails(Guid id, CancellationToken cancellationToken)
        {
            var operationResult = await this.ingredientService.GetIngredientWithDetails(id, cancellationToken);
            var ingredient = this.mapper.Map<IngredientWithDetailsDto, IngredientWithDetailsViewModel>(operationResult.Result);

            return Ok(ingredient);
        }
    }
}
