using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
    }
}
