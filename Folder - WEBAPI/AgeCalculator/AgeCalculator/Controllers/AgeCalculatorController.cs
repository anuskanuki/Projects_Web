using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgeCalculator.Controllers
{
    public class AgeCalculatorController : ApiController
    {
        public string Get()
        {
            return "App to drink tonight";
        }

        public string Get(int birthYear,string userName="User")
        {
            if ((DateTime.Now.Year - birthYear) >= 18)
            {
                return $"{userName}, according to the system, you may drink alcoolichs drinks" ;
            }
            else
            {
                return "{userName}, according to the system, you may drink juice or milk";
            }
        }

    }
}
