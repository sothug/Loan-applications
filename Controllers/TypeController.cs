using Microsoft.AspNetCore.Mvc;
using Loan_applications.Domains;
using Loan_applications.Storage;

namespace Loan_applications.Controllers
{
    [ApiController]
    [Route("/Type")]
    public class TypeController : ControllerBase
    {
        [HttpPost("Create")]
        public bool Create(TypeOfLending typeOfLending)
        {
            return Storages.TypeStorage.Create(typeOfLending);
        }

        [HttpGet("Read")]
        public TypeOfLending Read(int ID)
        {
            return Storages.TypeStorage.Read(ID);
        }

        [HttpPut("Update")]
        public TypeOfLending Update(TypeOfLending typeOfLending)
        {
            return Storages.TypeStorage.Update(typeOfLending);
        }

        [HttpDelete("Delete")]
        public bool Delete(int ID)
        {
            return Storages.TypeStorage.Delete(ID);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.TypeStorage.SaveToXMLFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.TypeStorage.ReadFromXMLFile();
        }
    }
}
