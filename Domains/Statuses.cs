namespace Loan_applications.Domains
{
    public enum Statuses
    {
        InsufficientInformation = -2,
        RejectedApplication = -1,
        NewApplication = 0,
        VerifiedApplication = 1,
        AgreementSigned = 2
    }

    public static class StatusDescriptor
    {
        public static string Describe(Statuses status) =>
            status switch
            {
                Statuses.InsufficientInformation => "Insufficient Information In The Application",
                Statuses.RejectedApplication => "Rejected Application",
                Statuses.NewApplication => "New Application",
                Statuses.VerifiedApplication => "Verified Application",
                Statuses.AgreementSigned => "Agreement Signed",
                _ => "Unknown status"
            };
    }
}