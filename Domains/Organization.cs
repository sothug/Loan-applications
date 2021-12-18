using Loan_applications.Repository;

namespace Loan_applications.Domains
{
    public class Organization : IIdentifier
    {
        public int Id { get; set; }
        public string TIN { get; set; } //Taxpayer Identification Number - Идентификационный номер налогоплательщика (ИНН)
        public string Name { get; set; }
        public string Adress { get; set; }
        public string CorCheck { get; set; }
        public string CheckingAccount { get; set; }
        public string TRRC { get; set; } // Tax Registration Reason Code - Код причины постановки на налоговый учет (КПП)
        public string RCBIC { get; set; } // Russian Central Bank Identifier Code - Банковский идентификационный код (БИК)
    }
}
