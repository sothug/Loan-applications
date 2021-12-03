using Loan_applications.Repository;

namespace Loan_applications.Domains
{
    public class Client : IIdentifier
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string HomeAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkAdress { get; set; }
        public string PositionAtWork { get; set; }
        public int Income { get; set; }

        public Client() { }

        public Client(int id, string firstName, string secondName, string lastName, string homeAdress, string phoneNumber, string workAdress, string positionAtWork, int income)
        {
            ID = id;
            FirstName = firstName;
            SecondName = secondName;
            LastName = lastName;
            HomeAdress = homeAdress;
            PhoneNumber = phoneNumber;
            WorkAdress = workAdress;
            PositionAtWork = positionAtWork;
            Income = income;
        }
    }
}
