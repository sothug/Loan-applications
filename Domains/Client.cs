using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Loan_applications.Domains
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string HomeAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkAdress { get; set; }
        public string PositionAtWork { get; set; }
        public int Income { get; set; }

        Client(int id, string firstName, string secondName, string lastName, string homeAdress, string phoneNumber, string workAdress, string positionAtWork, int income)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.LastName = lastName;
            this.HomeAdress = homeAdress;
            this.PhoneNumber = phoneNumber;
            this.WorkAdress = workAdress;
            this.PositionAtWork = positionAtWork;
            this.Income = income;
        }
    }
}
