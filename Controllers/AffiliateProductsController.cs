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
    public class AffiliateProductsController : ControllerBase
    {
        private readonly HashbzContext _context;

        public AffiliateProductsController(HashbzContext context)
        {
            _context = context;
        }

        //// GET: api/AffiliateProducts
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<AffiliateProducts>>> GetAffiliateProducts()
        //{
        //    return await _context.AffiliateProducts.ToListAsync();
        //}

        // GET: api/AffiliateProducts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AffiliateProductsList>>> GetAffiliateProducts()
        {
 


            return await (from p in _context.AffiliateProducts
                          orderby p.AffiliateProductId descending
                          select new AffiliateProductsList { Title = p.Title, AffiliateProductId = p.AffiliateProductId, Urltitle = p.Urltitle }).ToListAsync();
        }


        // GET: api/AffiliateProducts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<AffiliateProductsV>>> GetAffiliateProducts(int id)
        {


            return await _context.AffiliateProductsV.Where(x => x.AffiliateProductId == id).ToListAsync();
        }

        // PUT: api/AffiliateProducts/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAffiliateProducts(int id, AffiliateProducts affiliateProducts)
        {
            if (id != affiliateProducts.AffiliateProductId)
            {
                return BadRequest();
            }

            _context.Entry(affiliateProducts).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AffiliateProductsExists(id))
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

        // POST: api/AffiliateProducts
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<AffiliateProducts>> PostAffiliateProducts(AffiliateProducts affiliateProducts)
        {
            _context.AffiliateProducts.Add(affiliateProducts);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAffiliateProducts", new { id = affiliateProducts.AffiliateProductId }, affiliateProducts);
        }

        // DELETE: api/AffiliateProducts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AffiliateProducts>> DeleteAffiliateProducts(int id)
        {
            var affiliateProducts = await _context.AffiliateProducts.FindAsync(id);
            if (affiliateProducts == null)
            {
                return NotFound();
            }

            _context.AffiliateProducts.Remove(affiliateProducts);
            await _context.SaveChangesAsync();

            return affiliateProducts;
        }

        private bool AffiliateProductsExists(int id)
        {
            return _context.AffiliateProducts.Any(e => e.AffiliateProductId == id);
        }
    }
}
