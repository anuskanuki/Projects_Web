using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculoDePesoPelaMassa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversaoController : ControllerBase
    {

        [HttpPost]
        public ConversaoController Post(ConversaoController item)
        {
            return item;
        }
    }
}