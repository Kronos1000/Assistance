using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.Data;
using Backend.Models;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FurnituresController : ControllerBase
    {
        private readonly BackendContext _context;

        public FurnituresController(BackendContext context)
        {
            _context = context;
        }

        // GET: api/Furnitures
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Furniture>>> GetFurniture()
        {
          if (_context.Furniture == null)
          {
              return NotFound();
          }
            return await _context.Furniture.ToListAsync();
        }

        // GET: api/Furnitures/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Furniture>> GetFurniture(int id)
        {
          if (_context.Furniture == null)
          {
              return NotFound();
          }
            var furniture = await _context.Furniture.FindAsync(id);

            if (furniture == null)
            {
                return NotFound();
            }

            return furniture;
        }

        // PUT: api/Furnitures/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFurniture(int id, Furniture furniture)
        {
            if (id != furniture.furnitureID)
            {
                return BadRequest();
            }

            _context.Entry(furniture).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FurnitureExists(id))
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

        // POST: api/Furnitures
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Furniture>> PostFurniture(Furniture furniture)
        {
          if (_context.Furniture == null)
          {
              return Problem("Entity set 'BackendContext.Furniture'  is null.");
          }
            _context.Furniture.Add(furniture);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFurniture", new { id = furniture.furnitureID }, furniture);
        }

        // DELETE: api/Furnitures/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFurniture(int id)
        {
            if (_context.Furniture == null)
            {
                return NotFound();
            }
            var furniture = await _context.Furniture.FindAsync(id);
            if (furniture == null)
            {
                return NotFound();
            }

            _context.Furniture.Remove(furniture);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FurnitureExists(int id)
        {
            return (_context.Furniture?.Any(e => e.furnitureID == id)).GetValueOrDefault();
        }
    }
}
