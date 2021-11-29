using Microsoft.AspNetCore.Mvc;
using Loan_applications.Domains;
using Loan_applications.Storage;

namespace Loan_applications.Controllers
{
    [ApiController]
    [Route("/Agreement")]
    public class AgreementController : ControllerBase
    {
        [HttpPost("Create")]
        public bool Create(Agreement agreement)
        {
            return Storages.AgreementStorage.Create(agreement);
        }

        [HttpGet("Read")]
        public Agreement Read(int ID)
        {
            return Storages.AgreementStorage.Read(ID);
        }

        [HttpPut("Update")]
        public Agreement Update(Agreement agreement)
        {
            return Storages.AgreementStorage.Update(agreement);
        }

        [HttpDelete("Delete")]
        public bool Delete(int ID)
        {
            return Storages.AgreementStorage.Delete(ID);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.AgreementStorage.SaveToXMLFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.AgreementStorage.ReadFromXMLFile();
        }
    }
}
