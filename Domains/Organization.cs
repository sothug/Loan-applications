using Loan_applications.Repository;

namespace Loan_applications.Domains
{
    public class Organization : IIdentifier
    {
        public int ID { get; set; }
        public string TIN { get; set; } //Taxpayer Identification Number - Идентификационный номер налогоплательщика (ИНН)
        public string Name { get; set; }
        public string Adress { get; set; }
        public string CorCheck { get; set; }
        public string CheckingAccount { get; set; }
        public string TRRC { get; set; } // Tax Registration Reason Code - Код причины постановки на налоговый учет (КПП)
        public string RCBIC { get; set; } // Russian Central Bank Identifier Code - Банковский идентификационный код (БИК)

        public Organization() { }

        public Organization(int id, string TIN, string name, string adress, string corCheck, string checkingAccount, string TRRC, string RCBIC)
        {
            ID = id;
            this.TIN = TIN;
            Name = name;
            Adress = adress;
            CorCheck = corCheck;
            CheckingAccount = checkingAccount;
            this.TRRC = TRRC;
            this.RCBIC = RCBIC;
        }
    }
}
