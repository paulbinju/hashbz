using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hazhbz.Models;

namespace Hazhbz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApdetailsController : ControllerBase
    {
        private readonly HashbzContext _context;

        public ApdetailsController(HashbzContext context)
        {
            _context = context;
        }

        // GET: api/Apdetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Apdetails>>> GetApdetails()
        {
            return await _context.Apdetails.ToListAsync();
        }

        // GET: api/Apdetails/5
        [HttpGet("{id}")]
        public async Task<IEnumerable<Apdetails>> GetApdetails(int id)
        {

            return await _context.Apdetails.Where(x => x.AffiliateProductsId == id).ToListAsync();
        }

        // PUT: api/Apdetails/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApdetails(int id, Apdetails apdetails)
        {
            if (id != apdetails.ApdetailsId)
            {
                return BadRequest();
            }

            _context.Entry(apdetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApdetailsExists(id))
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

        // POST: api/Apdetails
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Apdetails>> PostApdetails(Apdetails apdetails)
        {
            _context.Apdetails.Add(apdetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetApdetails", new { id = apdetails.ApdetailsId }, apdetails);
        }

        // DELETE: api/Apdetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Apdetails>> DeleteApdetails(int id)
        {
            var apdetails = await _context.Apdetails.FindAsync(id);
            if (apdetails == null)
            {
                return NotFound();
            }

            _context.Apdetails.Remove(apdetails);
            await _context.SaveChangesAsync();

            return apdetails;
        }

        private bool ApdetailsExists(int id)
        {
            return _context.Apdetails.Any(e => e.ApdetailsId == id);
        }
    }
}
