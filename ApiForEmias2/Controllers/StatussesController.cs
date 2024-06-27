using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiForEmias2.Models;

namespace ApiForEmias2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatussesController : ControllerBase
    {
        private readonly EmiasApiContext _context;

        public StatussesController(EmiasApiContext context)
        {
            _context = context;
        }

        // GET: api/Statusses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Statuss>>> GetStatusses()
        {
            return await _context.Statusses.ToListAsync();
        }

        // GET: api/Statusses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Statuss>> GetStatuss(int? id)
        {
            var statuss = await _context.Statusses.FindAsync(id);

            if (statuss == null)
            {
                return NotFound();
            }

            return statuss;
        }

        // PUT: api/Statusses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStatuss(int? id, Statuss statuss)
        {
            if (id != statuss.IdStatus)
            {
                return BadRequest();
            }

            _context.Entry(statuss).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StatussExists(id))
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

        // POST: api/Statusses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Statuss>> PostStatuss(Statuss statuss)
        {
            _context.Statusses.Add(statuss);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStatuss", new { id = statuss.IdStatus }, statuss);
        }

        // DELETE: api/Statusses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStatuss(int? id)
        {
            var statuss = await _context.Statusses.FindAsync(id);
            if (statuss == null)
            {
                return NotFound();
            }

            _context.Statusses.Remove(statuss);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StatussExists(int? id)
        {
            return _context.Statusses.Any(e => e.IdStatus == id);
        }
    }
}
