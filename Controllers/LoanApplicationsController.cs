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
        [HttpPost]
        [Route("/Client/ChooseType")]
        public string ChooseType(string str)
        {
            return "Это метод выбора типа кредитования.";
        }

        [HttpPost]
        [Route("/Client/ChooseOrganization")]
        public string ChooseOrganization(string str)
        {
            return "Это метод выбора кредитной организации.";
        }

        [HttpPost]
        [Route("/Client/SubmitInformation")]
        public string SubmitInformation(string str)
        {
            return "Это метод предоставления нужной информации о клиенте.";
        }

        [HttpPost]
        [Route("/Client/Apply")]
        public string Apply(string str)
        {
            return "Это метод подачи заявки на кредит.";
        }
    }

    [ApiController]
    [Route("/Manager")]
    public class ManagerController : ControllerBase
    {
        [HttpGet]
        public string CheckingSolvency()
        {
            return "Это метод проверки платежеспособности клиента.";
        }
    }

    [ApiController]
    [Route("/Dispatcher")]
    public class DispatcherController : ControllerBase
    {
        [HttpGet]
        public string ProcessingApplications()
        {
            return "Это метод обработки заявок.";
        }
    }
}
