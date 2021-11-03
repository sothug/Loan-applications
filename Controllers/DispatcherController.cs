using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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

        [HttpPut("Create")]
        public string Create(string str)
        {
            return str;
        }

        [HttpGet("Read")]
        public string Read(string str)
        {
            return str;
        }

        [HttpPatch("Update")]
        public string Update(string str)
        {
            return str;
        }

        [HttpDelete("Delete")]
        public string Delete(string str)
        {
            return str;
        }
    }
}
