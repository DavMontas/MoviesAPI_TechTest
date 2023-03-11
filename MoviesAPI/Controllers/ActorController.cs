using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using MoviesAPI.Core.Application.Interfaces.Services;
using MoviesAPI.Core.Application.Dto;
using Swashbuckle.AspNetCore.Annotations;

namespace ActorsAPI.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ActorsController : ControllerBase
    {
        private readonly IActorService _svc;
        public ActorsController(IActorService svc)
        {
            _svc = svc;
        }


        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [SwaggerOperation(
            Summary = "List of Actors",
            Description = "Return all the recors on Actors"
            )]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var mList = await _svc.GetAllAsync();
                if (mList.Count == 0 || mList == null)
                {
                    return NotFound();
                }

                return Ok(mList);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("GetById/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [SwaggerOperation(
            Summary = "Actor",
            Description = "Get an actor by its id"
            )]
        public virtual async Task<IActionResult> GetById(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }

                var entity = await _svc.GetByIdAsync(id);

                if (entity == null)
                {
                    return NotFound();
                }

                return Ok(entity);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("add")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [SwaggerOperation(
            Summary = "Add Actor",
            Description = "add  new actor record"
            )]
        public virtual async Task<IActionResult> Add(ActorDto dto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Todos los campos son obligatorios.");
                }

                var enity = await _svc.AddAsync(dto);

                if (enity == null)
                {
                    return BadRequest("Ha ocurrido un problema.");
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }

        }

        [HttpPut("update/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [SwaggerOperation(
            Summary = "Update ",
            Description = "update an actor"
            )]
        public virtual async Task<IActionResult> Update(ActorDto dto, int id)
        {
            try
            {
                if (id == 0 || dto == null)
                {
                    return BadRequest();
                }

                var entity = await _svc.GetByIdAsync(id);

                if (entity == null)
                {
                    return NotFound();
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Todos los campos son obligatorios.");
                }

                await _svc.UpdateAsync(dto, id);

                return Ok(entity);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("delete/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [SwaggerOperation(
            Summary = "Delete",
            Description = "delete an actor by its id"
            )]
        public virtual async Task<IActionResult> delete(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }

                var entity = await _svc.GetByIdAsync(id);

                if (entity == null)
                {
                    return NotFound();
                }

                await _svc.DeleteAsync(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


    }
}
