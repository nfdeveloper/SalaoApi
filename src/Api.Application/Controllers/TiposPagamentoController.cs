using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.TipoPagamento;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TiposPagamentoController : ControllerBase
    {
        private ITipoPagamentoService _service;

        public TiposPagamentoController(ITipoPagamentoService service)
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

        [HttpGet("{id}", Name = "FindTipoPagamentoById")]
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
        public async Task<ActionResult> Post([FromBody] TipoPagamentoEntity tipoPagamento)
        {
             if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            try
            {
                var result = await _service.Post(tipoPagamento);
                if(result != null)
                {
                    return Created(new Uri(Url.Link("FindTipoPagamentoById", new { id = result.Id })), result);
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
        public async Task<ActionResult> Put([FromBody] TipoPagamentoEntity tipoPagamento)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _service.Put(tipoPagamento);
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