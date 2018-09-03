using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onboarding.Models;

namespace onboarding.Services
{
    public class CredentialsServices : ICredentialsServices
    {
        private readonly SignUpContext _context;

        public CredentialsServices(SignUpContext context)
        {
            _context = context;
        }
        public IEnumerable<Customer_Signup> GetAllSignUp()
        {
            return _context.Customer_Signup;
        }
        public async Task<Customer_Signup> GetSignUp(int id)
        {
            return await _context.Customer_Signup.FindAsync(id);
        }

        public async Task CreateCredentials(Customer_Signup customer_Signup)
        {
            _context.Customer_Signup.Add(customer_Signup);
            await _context.SaveChangesAsync();
        }
    }
}
