using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Loan_applications.Domains
{
    public class Organization
    {
        public int Id { get; set; }
        public string TIN { get; set; } //Taxpayer Identification Number - Идентификационный номер налогоплательщика (ИНН)
        public string Name { get; set; }
        public string Adress { get; set; }
        public string CorCheck { get; set; }
        public string CheckingAccount { get; set; }
        public string TRRC { get; set; } // Tax Registration Reason Code - Код причины постановки на налоговый учет (КПП)
        public string RCBIC { get; set; } // Russian Central Bank Identifier Code - Банковский идентификационный код (БИК)

        Organization(int id, string TIN, string name, string adress, string corCheck, string checkingAccount, string TRRC, string RCBIC)
        {
            this.Id = id;
            this.TIN = TIN;
            this.Name = name;
            this.Adress = adress;
            this.CorCheck = corCheck;
            this.CheckingAccount = checkingAccount;
            this.TRRC = TRRC;
            this.RCBIC = RCBIC;
        }
    }
}
