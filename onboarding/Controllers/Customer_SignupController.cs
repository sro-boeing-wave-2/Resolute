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
using onboarding.Services;

namespace onboarding.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Customer_SignupController : ControllerBase
    {
        private ICredentialsServices _service;
        public Customer_SignupController(ICredentialsServices service)
        {
            _service = service;
        }
        // GET: api/Customer_Signup
        [HttpGet]
        public IEnumerable<Customer_Signup> GetCustomer_Signup()
        {
            return _service.GetAllSignUp();
        }
        // GET: api/Customer_Signup/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomer_Signup([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Customer_Signup customer_Signup = await _service.GetSignUp(id);
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
            await _service.CreateCredentials(customer_Signup);
            return CreatedAtAction("GetCustomer_Signup", new { id = customer_Signup.id }, customer_Signup);
        }   
    }
}