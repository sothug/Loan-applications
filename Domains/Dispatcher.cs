using Loan_applications.Repository;

namespace Loan_applications.Domains
{
    public class Dispatcher : IIdentifier
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Dispatcher() { }

        public Dispatcher(int id, string firstName, string secondName, string lastName, string email)
        {
            ID = id;
            FirstName = firstName;
            SecondName = secondName;
            LastName = lastName;
            Email = email;
        }
    }
}
