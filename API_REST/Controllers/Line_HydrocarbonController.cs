using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_REST.Data;
using Bussiness_Logic.Models;

namespace API_REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Line_HydrocarbonController : ControllerBase
    {
        private readonly AppDBContext _context;

        public Line_HydrocarbonController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Line_Hydrocarbon
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Line_Hydrocarbon>>> GetLine_Hydrocarbons()
        {
            return await _context.Line_Hydrocarbons.ToListAsync();
        }

        // GET: api/Line_Hydrocarbon/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Line_Hydrocarbon>> GetLine_Hydrocarbon(int id)
        {
            var line_Hydrocarbon = await _context.Line_Hydrocarbons.FindAsync(id);

            if (line_Hydrocarbon == null)
            {
                return NotFound();
            }

            return line_Hydrocarbon;
        }

        // PUT: api/Line_Hydrocarbon/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLine_Hydrocarbon(int id, Line_Hydrocarbon line_Hydrocarbon)
        {
            if (id != line_Hydrocarbon.Id_LineHydrocarbon)
            {
                return BadRequest();
            }

            _context.Entry(line_Hydrocarbon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Line_HydrocarbonExists(id))
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

        // POST: api/Line_Hydrocarbon
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Line_Hydrocarbon>> PostLine_Hydrocarbon(Line_Hydrocarbon line_Hydrocarbon)
        {
            _context.Line_Hydrocarbons.Add(line_Hydrocarbon);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLine_Hydrocarbon", new { id = line_Hydrocarbon.Id_LineHydrocarbon }, line_Hydrocarbon);
        }

        // DELETE: api/Line_Hydrocarbon/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Line_Hydrocarbon>> DeleteLine_Hydrocarbon(int id)
        {
            var line_Hydrocarbon = await _context.Line_Hydrocarbons.FindAsync(id);
            if (line_Hydrocarbon == null)
            {
                return NotFound();
            }

            _context.Line_Hydrocarbons.Remove(line_Hydrocarbon);
            await _context.SaveChangesAsync();

            return line_Hydrocarbon;
        }

        private bool Line_HydrocarbonExists(int id)
        {
            return _context.Line_Hydrocarbons.Any(e => e.Id_LineHydrocarbon == id);
        }
    }
}
