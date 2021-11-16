using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Loan_applications.Domains
{
    public class Agreement
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public int ClientId { get; set; }
        public DateTime When { get; set; }
        public int OrganizationId { get; set; }

        Agreement(int id, int applicationId, int clientId, DateTime when, int organizationId)
        {
            this.Id = id;
            this.ApplicationId = applicationId;
            this.ClientId = clientId;
            this.When = when;
            this.OrganizationId = organizationId;
        }
    }
}
