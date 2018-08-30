using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using onboarding.Models;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Options;

namespace onboarding.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Customer_SignupController : ControllerBase
    {
        private readonly SignUpContext _context;

        public Customer_SignupController(SignUpContext context)
        {
            _context = context;
        }

        // GET: api/Customer_Signup
        [HttpGet]
        public IEnumerable<Customer_Signup> GetCustomer_Signup()
        {
            return _context.Customer_Signup;
        }

        // GET: api/Customer_Signup/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomer_Signup([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var customer_Signup = await _context.Customer_Signup.FindAsync(id);

            if (customer_Signup == null)
            {
                return NotFound();
            }

            return Ok(customer_Signup);
        }

        // POST: api/Customer_Signup
        [HttpPost]
        public async Task<IActionResult> PostCustomer_Signup([FromBody] Customer_Signup customer_Signup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Customer_Signup.Add(customer_Signup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomer_Signup", new { id = customer_Signup.id }, customer_Signup);
        }

        private bool Customer_SignupExists(int id)
        {
            return _context.Customer_Signup.Any(e => e.id == id);
        }
    }
}