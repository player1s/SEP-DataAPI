using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace SEP_DataAPI.Controllers
{
        // controller for endpoint ~/api/Login in the webAPI

    [Route("[controller]")]
    [ApiController]
    public class GetAllAccountsController : ControllerBase
    {
        // GET /GetAllAccounts
        [HttpGet]
        public ActionResult<string> Get()
        {
            return 4 + "";
        }        
    } 
}
