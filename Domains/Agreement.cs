using System;
using Loan_applications.Storage;

namespace Loan_applications.Domains
{
    public class Agreement : WithID
    {
        public int ApplicationId { get; set; }
        public int ClientId { get; set; }
        public DateTime When { get; set; }
        public int OrganizationId { get; set; }

        public Agreement() { }

        public Agreement(int id, int applicationId, int clientId, DateTime when, int organizationId)
        {
            this.ID = id;
            this.ApplicationId = applicationId;
            this.ClientId = clientId;
            this.When = when;
            this.OrganizationId = organizationId;
        }
    }
}
