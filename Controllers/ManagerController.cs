using Microsoft.AspNetCore.Mvc;
using Loan_applications.Domains;
using Loan_applications.Repository;

namespace Loan_applications.Controllers
{
    [ApiController]
    [Route("/Manager")]
    public class ManagerController : ControllerBase
    {
        [HttpGet("CheckingSolvency")]
        public string CheckingSolvency(string str)
        {
            return str;
        }

        [HttpGet("ReceivingApplications")]
        public string ReceivingApplications(string str)
        {
            return str;
        }

        [HttpPost("Create")]
        public bool Create(Manager manager)
        {
            return Storages.ManagerStorage.Create(manager);
        }

        [HttpGet("Read")]
        public Manager Read(int ID)
        {
            return Storages.ManagerStorage.Read(ID);
        }

        [HttpPut("Update")]
        public Manager Update(Manager manager)
        {
            return Storages.ManagerStorage.Update(manager);
        }

        [HttpDelete("Delete")]
        public bool Delete(int ID)
        {
            return Storages.ManagerStorage.Delete(ID);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.ManagerStorage.SaveToXMLFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.ManagerStorage.ReadFromXMLFile();
        }
    }
}
