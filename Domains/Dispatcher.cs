using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Loan_applications.Domains
{
    public class Dispatcher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        Dispatcher(int id, string firstName, string secondName, string lastName, string email)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.LastName = lastName;
            this.Email = email;
        }
    }
}
