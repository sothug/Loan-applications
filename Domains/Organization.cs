using Loan_applications.Storage;

namespace Loan_applications.Domains
{
    public class Organization : WithID
    {
        public string TIN { get; set; } //Taxpayer Identification Number - Идентификационный номер налогоплательщика (ИНН)
        public string Name { get; set; }
        public string Adress { get; set; }
        public string CorCheck { get; set; }
        public string CheckingAccount { get; set; }
        public string TRRC { get; set; } // Tax Registration Reason Code - Код причины постановки на налоговый учет (КПП)
        public string RCBIC { get; set; } // Russian Central Bank Identifier Code - Банковский идентификационный код (БИК)

        public Organization(int id, string TIN, string name, string adress, string corCheck, string checkingAccount, string TRRC, string RCBIC)
        {
            this.ID = id;
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
