using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace IMC_Calculator.Controllers
{
    public class ImcController : ApiController
    {
        public string Get()
        {
            return "App to calculate your IMC";
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public double Get(double weight, double height, string userName = "User")
        {
            var imc = weight / (height * height);

            return imc;
        }


        


    }
}
