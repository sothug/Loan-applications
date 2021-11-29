using Loan_applications.Storage;

namespace Loan_applications.Domains
{
    public class Client : WithID
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string HomeAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkAdress { get; set; }
        public string PositionAtWork { get; set; }
        public int Income { get; set; }

        public Client(int id, string firstName, string secondName, string lastName, string homeAdress, string phoneNumber, string workAdress, string positionAtWork, int income)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.LastName = lastName;
            this.HomeAdress = homeAdress;
            this.PhoneNumber = phoneNumber;
            this.WorkAdress = workAdress;
            this.PositionAtWork = positionAtWork;
            this.Income = income;
        }
    }
}
