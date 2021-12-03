using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using Loan_applications.Domains;

namespace Loan_applications.Repository
{
    public interface IIdentifier
    {
        public int ID { get; set; }
    }
}
