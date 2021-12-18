using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using Loan_applications.Domains;

namespace Loan_applications.Repository
{
    public static class Storages
    {
        public static readonly Storage<Agreement> AgreementStorage = new();
        public static readonly Storage<Application> ApplicationStorage = new();
        public static readonly Storage<Client> ClientStorage = new();
        public static readonly Storage<Dispatcher> DispatcherStorage  = new();
        public static readonly Storage<Manager> ManagerStorage = new();
        public static readonly Storage<Organization> OrganizationStorage = new();
        public static readonly Storage<TypeOfLending> TypeStorage = new();
    }
}
