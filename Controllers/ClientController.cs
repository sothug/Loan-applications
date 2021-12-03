using Microsoft.AspNetCore.Mvc;
using Loan_applications.Domains;
using Loan_applications.Repository;

namespace Loan_applications.Controllers
{
    [ApiController]
    [Route("/Client")]
    public class ClientController : ControllerBase
    {
        [HttpPost("ChooseType")]
        public string ChooseType(string str)
        {
            return str;
        }

        [HttpPost("ChooseOrganization")]
        public string ChooseOrganization(string str)
        {
            return str;
        }

        [HttpPost("SubmitInformation")]
        public string SubmitInformation(string str)
        {
            return str;
        }

        [HttpPost("Apply")]
        public string Apply(string str)
        {
            return str;
        }

        [HttpPost("Create")]
        public bool Create(Client client)
        {
            return Storages.ClientStorage.Create(client);
        }

        [HttpGet("Read")]
        public Client Read(int ID)
        {
            return Storages.ClientStorage.Read(ID);
        }

        [HttpPut("Update")]
        public Client Update(Client client)
        {
            return Storages.ClientStorage.Update(client);
        }

        [HttpDelete("Delete")]
        public bool Delete(int ID)
        {
            return Storages.ClientStorage.Delete(ID);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.ClientStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.ClientStorage.ReadFromXmlFile();
        }
    }
}
