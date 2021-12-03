using System;
using System.Collections.Generic;
using Loan_applications.Repository;

namespace Loan_applications.Domains
{
    public class Application : IIdentifier
    {
        static private Dictionary<int, string> Statuses = new Dictionary<int, string>
        {
            {-2, "Insufficient information in the application" },
            {-1, "Rejected application" },
            {0, "New application" },
            {1, "Verified application" },
            {2, "Agreement signed"}
        };
        public int ID { get; set; }
        public int ClientId { get; set; }
        public int DispatcherId { get; set; }
        public int ManagerId { get; set; }
        public int Amount { get; set; }
        public DateTime When { get; set; }
        public int TypeId { get; set; }
        public int OrganizationId { get; set; }
        public int StatusCode { get; set; }

        public Application() { }

        public Application(int id, int clientId, int amount, DateTime when, int typeId)
        {
            ID = id;
            ClientId = clientId;
            Amount = amount;
            When = when;
            TypeId = typeId;
            StatusCode = 0;
        }

        string GetState()
        {
            return Statuses[StatusCode];
        }
    }
}
