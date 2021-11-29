using Loan_applications.Storage;

namespace Loan_applications.Domains
{
    public class Manager : WithID
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int OrganizationId { get; set; }

        public Manager(int id, string firstName, string secondName, string lastName, string email)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.LastName = lastName;
            this.Email = email;
        }
    }
}
