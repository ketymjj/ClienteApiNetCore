using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CadastroCliente.Data;
using CadastroCliente.Models;

namespace CadastroCliente.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteContext _context;

        public ClienteController(ClienteContext context)
        {
            _context = context;
        }


        // GET: api/Cliente
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClienteModel>>> Get()
        {
            return await _context.ClienteModel.ToListAsync();
        }
        // GET: api/Cliente/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var clienteModel = await _context.ClienteModel.FindAsync(id);

            if (clienteModel == null)
            {
                return NotFound();
            }

            return Ok(clienteModel);
        }

        // PUT: api/Cliente/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] long id, [FromBody] ClienteModel clienteModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != clienteModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(clienteModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClienteModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Cliente
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ClienteModel clienteModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ClienteModel.Add(clienteModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClienteModel", new { id = clienteModel.Id }, clienteModel);
        }

        // DELETE: api/Cliente/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var clienteModel = await _context.ClienteModel.FindAsync(id);
            if (clienteModel == null)
            {
                return NotFound();
            }

            _context.ClienteModel.Remove(clienteModel);
            await _context.SaveChangesAsync();

            return Ok(clienteModel);
        }

        private bool ClienteModelExists(long id)
        {
            return _context.ClienteModel.Any(e => e.Id == id);
        }
    }
}