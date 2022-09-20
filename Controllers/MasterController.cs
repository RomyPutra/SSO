using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XAXO.Controllers
{
    [Route("api/Master")]
    public class MasterController : Controller
    {
        [HttpGet]
        [Route("Test_Swaggers")]
        public async Task<string> TestSwaggers()
        {
            return "Tested";
        }
    }
}
