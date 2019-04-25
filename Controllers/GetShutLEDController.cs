using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SEP_DataAPI.Logic;
using SEP_DataAPI.Model;

namespace SEP_DataAPI.Controllers
{
    // controller for endpoint ~/api/Login in the webAPI

    [Route("[controller]")]
    [ApiController]
    public class GetShutLEDController : ControllerBase
    {
        // GET /GetShutLED
        [HttpGet]
        public void Get()
        {
            ClientToBridgeApp client = new ClientToBridgeApp();
            client.GetShutLED();
        }        
    } 
}
