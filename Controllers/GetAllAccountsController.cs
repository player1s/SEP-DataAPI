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
    /*
    *    If a request arrives for this endpoint, this method will run. Every writeline is to better understand the program while running
    *    intentionally having a single post request, as other functions are located in other endpoints 
    *    1, create an object that the incoming object will be stored in
    *    2, deserialize the incoming Json to the specified object
    *    3, if the command (intention of presentation layer) matches a possible function, call that function.
    */
        // POST api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return 4 + "";
        }        
    } 
}
