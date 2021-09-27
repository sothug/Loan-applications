using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Loan_applications.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoanApplicationsController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            var rng = new Random();
            return "Да?";
        }
    }
}
