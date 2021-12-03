using System;
using Loan_applications.Repository;

namespace Loan_applications.Domains
{
    public class Agreement : IIdentifier
    {
        public int ID { get; set; }
        public int ApplicationId { get; set; }
        public int ClientId { get; set; }
        public DateTime When { get; set; }
        public int OrganizationId { get; set; }

        public Agreement() { }

        public Agreement(int id, int applicationId, int clientId, DateTime when, int organizationId)
        {
            ID = id;
            ApplicationId = applicationId;
            ClientId = clientId;
            When = when;
            OrganizationId = organizationId;
        }
    }
}
