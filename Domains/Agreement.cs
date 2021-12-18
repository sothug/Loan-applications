using System;
using Loan_applications.Repository;

namespace Loan_applications.Domains
{
    public class Agreement : IIdentifier
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public int ClientId { get; set; }
        public DateTime When { get; set; }
        public int OrganizationId { get; set; }
    }
}
