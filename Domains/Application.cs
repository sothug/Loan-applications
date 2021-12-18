using System;
using System.Collections.Generic;
using Loan_applications.Repository;

namespace Loan_applications.Domains
{
    public class Application : IIdentifier
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int DispatcherId { get; set; }
        public int ManagerId { get; set; }
        public int Amount { get; set; }
        public DateTime When { get; set; }
        public int TypeId { get; set; }
        public int OrganizationId { get; set; }
        public Statuses Status { get; set; }

        public string GetState() => StatusDescriptor.Describe(Status);
    }
}