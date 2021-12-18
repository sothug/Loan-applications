using Loan_applications.Repository;

namespace Loan_applications.Domains
{
    public class Dispatcher : IIdentifier
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
