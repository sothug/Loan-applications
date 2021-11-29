using System;
using System.Collections.Generic;
using Loan_applications.Storage;

namespace Loan_applications.Domains
{
    public class Application : WithID
    {
        static private Dictionary<int, string> Statuses = new Dictionary<int, string>
        {
            {-2, "Insufficient information in the application" },
            {-1, "Rejected application" },
            {0, "New application" },
            {1, "Verified application" },
            {2, "Agreement signed"}
        };
        public int ClientId { get; set; }
        public int DispatcherId { get; set; }
        public int ManagerId { get; set; }
        public int Amount { get; set; }
        public DateTime When { get; set; }
        public int TypeId { get; set; }
        public int OrganizationId { get; set; }
        public int StatusCode { get; set; }

        public Application(int id, int clientId, int amount, DateTime when, int typeId)
        {
            this.ID = id;
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
