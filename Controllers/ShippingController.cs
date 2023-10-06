using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CargoTrack_Backend.Database;
using CargoTrack_Backend.Models;

namespace CargoTrack_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShippingController : ControllerBase
    {
        private ShippingDbContext _context;

        public ShippingController(ShippingDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Shipping> Get()
        {
            return _context.Shippings.ToList();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var shipping = _context.Shippings.Find(id);
            if (shipping == null)
            {
                return NotFound();
            }
            return Ok(shipping);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Shipping shipping)
        {
            if (shipping == null)
            {
                return BadRequest();
            }

            _context.Shippings.Add(shipping);
            _context.SaveChanges();

            if (shipping.ShippingId > 0)
            {
                return CreatedAtAction("Get", new { id = shipping.ShippingId }, shipping);
            }
            else
            {
                return StatusCode(500);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Shipping shipping)
        {
            if (shipping == null)
            {
                return BadRequest();
            }

            if (id != shipping.ShippingId)
            {
                return BadRequest();
            }

            _context.Entry(shipping).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var shipping = _context.Shippings.Find(id);
            if (shipping == null)
            {
                return NotFound();
            }

            _context.Shippings.Remove(shipping);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpGet("ByCustomerId")]
        public IActionResult GetByCustomerId(int customerId)
        {
            var shipments = _context.Shippings.Where(s => s.CustomerId == customerId).ToList();

            if (shipments.Count == 0)
            {
                return NotFound();
            }

            return Ok(shipments);
        }
    }
}