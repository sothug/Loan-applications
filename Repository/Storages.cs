using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using Loan_applications.Domains;

namespace Loan_applications.Repository
{
    public class Storages
    {
        public static Storage<Agreement> AgreementStorage { get; } = new();
        public static Storage<Application> ApplicationStorage { get; } = new();
        public static Storage<Client> ClientStorage { get; } = new();
        public static Storage<Dispatcher> DispatcherStorage { get; } = new();
        public static Storage<Manager> ManagerStorage { get; } = new();
        public static Storage<Organization> OrganizationStorage { get; } = new();
        public static Storage<TypeOfLending> TypeStorage { get; } = new();
    }
}
