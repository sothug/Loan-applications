using Microsoft.AspNetCore.Mvc;
using Loan_applications.Domains;
using Loan_applications.Storage;

namespace Loan_applications.Controllers
{
    [ApiController]
    [Route("/Dispatcher")]
    public class DispatcherController : ControllerBase
    {
        [HttpGet("ProcessingApplications")]
        public string ProcessingApplications(string str)
        {
            return str;
        }

        [HttpGet("TransferApplication")]
        public string TransferApplication(string str)
        {
            return str;
        }

        [HttpPost("Create")]
        public bool Create(Dispatcher dispatcher)
        {
            return Storages.DispatcherStorage.Create(dispatcher);
        }

        [HttpGet("Read")]
        public Dispatcher Read(int ID)
        {
            return Storages.DispatcherStorage.Read(ID);
        }

        [HttpPut("Update")]
        public Dispatcher Update(Dispatcher dispatcher)
        {
            return Storages.DispatcherStorage.Update(dispatcher);
        }

        [HttpDelete("Delete")]
        public bool Delete(int ID)
        {
            return Storages.DispatcherStorage.Delete(ID);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.DispatcherStorage.SaveToXMLFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.DispatcherStorage.ReadFromXMLFile();
        }
    }
}
