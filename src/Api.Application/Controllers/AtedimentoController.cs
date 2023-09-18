using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.AtendimentoService;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AtedimentoController : ControllerBase
    {
        private IAtendimentoService _service;

        public AtedimentoController(IAtendimentoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException e)
            {               
                return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet("{id}", Name = "FindAtendimentoById")]
        public async Task<ActionResult> Get(int id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _service.Get(id));
            }
            catch (ArgumentException e)
            {               
                return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AtendimentoEntity atendimento)
        {
             if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            try
            {
                var result = await _service.Post(atendimento);
                if(result != null)
                {
                    return Created(new Uri(Url.Link("FindAtendimentoById", new { id = result.Id })), result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {               
                return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }                     
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] AtendimentoEntity atendimento)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _service.Put(atendimento);
                if(result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {               
                return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            } 
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _service.Delete(id));
            }
            catch (ArgumentException e)
            {               
                return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}