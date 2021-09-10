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
    public class AffiliatesController : ControllerBase
    {
        private readonly HashbzContext _context;

        public AffiliatesController(HashbzContext context)
        {
            _context = context;
        }

        // GET: api/Affiliates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Affiliate>>> GetAffiliate()
        {
            return await _context.Affiliate.ToListAsync();
        }

        // GET: api/Affiliates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Affiliate>> GetAffiliate(int id)
        {
            var affiliate = await _context.Affiliate.FindAsync(id);

            if (affiliate == null)
            {
                return NotFound();
            }

            return affiliate;
        }

        // PUT: api/Affiliates/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAffiliate(int id, Affiliate affiliate)
        {
            if (id != affiliate.AffiliateId)
            {
                return BadRequest();
            }

            _context.Entry(affiliate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AffiliateExists(id))
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

        // POST: api/Affiliates
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Affiliate>> PostAffiliate(Affiliate affiliate)
        {
            _context.Affiliate.Add(affiliate);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAffiliate", new { id = affiliate.AffiliateId }, affiliate);
        }

        // DELETE: api/Affiliates/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Affiliate>> DeleteAffiliate(int id)
        {
            var affiliate = await _context.Affiliate.FindAsync(id);
            if (affiliate == null)
            {
                return NotFound();
            }

            _context.Affiliate.Remove(affiliate);
            await _context.SaveChangesAsync();

            return affiliate;
        }

        private bool AffiliateExists(int id)
        {
            return _context.Affiliate.Any(e => e.AffiliateId == id);
        }
    }
}
