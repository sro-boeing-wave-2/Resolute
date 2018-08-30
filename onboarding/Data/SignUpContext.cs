using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace onboarding.Models
{
    public class SignUpContext : DbContext
    {
        public SignUpContext (DbContextOptions<SignUpContext> options)
            : base(options)
        {
        }

        public DbSet<onboarding.Models.Customer_Signup> Customer_Signup { get; set; }
    }
}
