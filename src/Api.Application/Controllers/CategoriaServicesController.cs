using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Interfaces.Services.CategoriaServico;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaServicesController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetAll([FromServices] ICategoriaServicoService service)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await service.GetAll());
            }
            catch (ArgumentException e)
            {               
                return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}