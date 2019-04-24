using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SEP_DataAPI.Logic;
using SEP_DataAPI.Model;

namespace SEP_DataAPI.Controllers
{
    // controller for endpoint ~/api/Login in the webAPI

    [Route("[controller]")]
    [ApiController]
    public class EditAccountController : ControllerBase
    {
        [HttpPost]
        public void Post([FromBody] string value)
        {
            DatabaseHandler dbHandler = new DatabaseHandler();
            JsonHandler jsonHandler = new JsonHandler();
            List<Account> list = new List<Account>();
            Account acc;

            acc = jsonHandler.deSerializeAccount(value);
            dbHandler.editAccount(acc);
        }        
    } 
}
