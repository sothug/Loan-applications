using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
    }
}
