using System.Web.Http;
using System.Web.Http.Cors;
using IMC_Calculator.Models;

namespace IMC_Calculator.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ImcController : ApiController
    {

        [HttpGet]
        [Route("Api/Imc/Msg")]
        public string ShowMsg(double weight, double height)
        {
            var result = "";
            var imcPeople = GetImc(weight, height);

            if (imcPeople < 18.5)
            {
                result = "thinness";
            }
            else if ((imcPeople > 18.5) && (imcPeople < 24.9))
            {
                result = "normal";
            }
            else if ((imcPeople > 25) && (imcPeople < 29.9))
            {
                result = "overweight";
            }
            else if ((imcPeople > 30) && (imcPeople < 39.9))
            {
                result = "obesity";
            }
            else
            {
                result = "severe obesity";
            }

            return result;
        }

        [HttpGet]
        public Imc CalcIMC(double weight, double height, string name)
        {
           var result= GetImc(weight, height);

            Imc objectImc = new Imc()
            {
                ImcValue = result,
                Text = $"{name}, your IMC is: {result}"
            };

            return objectImc;
        }


        [HttpGet]
        public double GetImc(double weight, double height)
        {
            var imc = weight / (height * height);
            return imc;
        }





    }
}
