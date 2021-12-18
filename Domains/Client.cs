using Loan_applications.Repository;
using System;

namespace Loan_applications.Domains
{
    public class Client : IIdentifier
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string HomeAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkAdress { get; set; }
        public string PositionAtWork { get; set; }
        public int Income { get; set; }
    }
}
