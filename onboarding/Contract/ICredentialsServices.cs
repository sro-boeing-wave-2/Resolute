using System.Collections.Generic;
using System.Threading.Tasks;
using onboarding.Models;

namespace onboarding.Services
{
    public interface ICredentialsServices
    {
        Task CreateCredentials(Customer_Signup customer_Signup);
        IEnumerable<Customer_Signup> GetAllSignUp();
        Task<Customer_Signup> GetSignUp(int id);
    }
}