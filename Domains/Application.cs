using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Loan_applications.Domains
{
    public class Application
    {
        static private Dictionary<int, string> Statuses = new Dictionary<int, string>
        {
            {-2, "Insufficient information in the application" },
            {-1, "Rejected application" },
            {0, "New application" },
            {1, "Verified application" },
            {2, "Agreement signed"}
        };
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int DispatcherId { get; set; }
        public int ManagerId { get; set; }
        public int Amount { get; set; }
        public DateTime When { get; set; }
        public int TypeId { get; set; }
        public int OrganizationId { get; set; }
        public int StatusCode { get; set; }

        Application(int id, int clientId, int amount, DateTime when, int typeId)
        {
            this.Id = id;
            this.ClientId = clientId;
            this.Amount = amount;
            this.When = when;
            this.TypeId = typeId;
            this.StatusCode = 0;
        }

        string GetState()
        {
            return Statuses[this.StatusCode];
        }
    }
}
