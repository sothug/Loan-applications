using Loan_applications.Repository;

namespace Loan_applications.Domains
{
    public class TypeOfLending : IIdentifier
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public float InterestRate { get; set; }
    }
}
