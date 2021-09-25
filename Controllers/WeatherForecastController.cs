using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Deans_Office.Controllers
{
    [ApiController]
    [Route("/rnd")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public int GetRnd()
        {
            var rng = new Random();
            return rng.Next();
        }

        [HttpPost]
        [Route("/rnd/lim")]
        public int GetLimRnd(int i)
        {
            var rng = new Random();
            return rng.Next() % i;
        }
    }
}
