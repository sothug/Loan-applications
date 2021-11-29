using Loan_applications.Storage;

namespace Loan_applications.Domains
{
    public class TypeOfLending : WithID
    {
        public string Type { get; set; }
        public float InterestRate { get; set; }

        public TypeOfLending(int id, string type, float interestRate)
        {
            this.ID = id;
            this.Type = type;
            this.InterestRate = interestRate;
        }
    }
}
