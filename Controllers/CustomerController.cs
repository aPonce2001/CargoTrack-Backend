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
    public class CustomerController : ControllerBase
    {
        private ShippingDbContext _context;

        public CustomerController(ShippingDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _context.Customers.ToList();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var customer = _context.Customers.Find(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest();
            }

            _context.Customers.Add(customer);
            _context.SaveChanges();

            if (customer.CustomerId > 0)
            {
                return CreatedAtAction("Get", new { id = customer.CustomerId }, customer);
            }
            else
            {
                return StatusCode(500);
            }
        }
    }
}