using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminclassController : ControllerBase
    {
        private readonly APIDbContext _context;

        public AdminclassController(APIDbContext context)
        {
            _context = context;
        }

        // GET: api/Adminclasses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Adminclass>>> GetAdmins()
        {
          if (_context.Admins == null)
          {
              return NotFound();
          }
            return await _context.Admins.ToListAsync();
        }

        // GET: api/Adminclasses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Adminclass>> GetAdminclass(string id)
        {
          if (_context.Admins == null)
          {
              return NotFound();
          }
            var adminclass = await _context.Admins.FindAsync(id);

            if (adminclass == null)
            {
                return NotFound();
            }

            return adminclass;
        }

        // PUT: api/Adminclasses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdminclass(string id, Adminclass adminclass)
        {
            if (id != adminclass.AdminId)
            {
                return BadRequest();
            }

            _context.Entry(adminclass).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdminclassExists(id))
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

        // POST: api/Adminclasses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Adminclass>> PostAdminclass(Adminclass adminclass)
        {
          if (_context.Admins == null)
          {
              return Problem("Entity set 'APIDbContext.Admins'  is null.");
          }
            _context.Admins.Add(adminclass);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AdminclassExists(adminclass.AdminId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAdminclass", new { id = adminclass.AdminId }, adminclass);
        }

        // DELETE: api/Adminclasses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdminclass(string id)
        {
            if (_context.Admins == null)
            {
                return NotFound();
            }
            var adminclass = await _context.Admins.FindAsync(id);
            if (adminclass == null)
            {
                return NotFound();
            }

            _context.Admins.Remove(adminclass);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AdminclassExists(string id)
        {
            return (_context.Admins?.Any(e => e.AdminId == id)).GetValueOrDefault();
        }
    }
}
