﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Loan_applications.Domains
{
    public class Type
    {
        public int Id { get; set; }
        public string TypeOfLending { get; set; }
        public int InterestRate { get; set; }

        Type(int id, string typeOfLending, int interestRate)
        {
            this.Id = id;
            this.TypeOfLending = typeOfLending;
            this.InterestRate = interestRate;
        }
    }
}