using Loan_applications.Repository;

namespace Loan_applications.Domains
{
    public class TypeOfLending : IIdentifier
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public float InterestRate { get; set; }

        public TypeOfLending() { }

        public TypeOfLending(int id, string type, float interestRate)
        {
            ID = id;
            Type = type;
            InterestRate = interestRate;
        }
    }
}
