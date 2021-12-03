using Microsoft.AspNetCore.Mvc;
using Loan_applications.Domains;
using Loan_applications.Repository;

namespace Loan_applications.Controllers
{
    [ApiController]
    [Route("/Application")]
    public class ApplicationController : ControllerBase
    {
        [HttpPost("Create")]
        public bool Create(Application application)
        {
            return Storages.ApplicationStorage.Create(application);
        }

        [HttpGet("Read")]
        public Application Read(int ID)
        {
            return Storages.ApplicationStorage.Read(ID);
        }

        [HttpPut("Update")]
        public Application Update(Application application)
        {
            return Storages.ApplicationStorage.Update(application);
        }

        [HttpDelete("Delete")]
        public bool Delete(int ID)
        {
            return Storages.ApplicationStorage.Delete(ID);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.ApplicationStorage.SaveToXMLFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.ApplicationStorage.ReadFromXMLFile();
        }
    }
}
