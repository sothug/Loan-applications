using Microsoft.AspNetCore.Mvc;
using Loan_applications.Domains;
using Loan_applications.Repository;

namespace Loan_applications.Controllers
{
    [ApiController]
    [Route("/Organization")]
    public class OrganizationController : ControllerBase
    {
        [HttpPost("Create")]
        public bool Create(Organization organization)
        {
            return Storages.OrganizationStorage.Create(organization);
        }

        [HttpGet("Read")]
        public Organization Read(int ID)
        {
            return Storages.OrganizationStorage.Read(ID);
        }

        [HttpPut("Update")]
        public Organization Update(Organization organization)
        {
            return Storages.OrganizationStorage.Update(organization);
        }

        [HttpDelete("Delete")]
        public bool Delete(int ID)
        {
            return Storages.OrganizationStorage.Delete(ID);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.OrganizationStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.OrganizationStorage.ReadFromXmlFile();
        }
    }
}
