using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SEP_DataAPI.Logic;
using SEP_DataAPI.Model;

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
            DatabaseHandler dbHandler = new DatabaseHandler();
            JsonHandler jsonHandler = new JsonHandler();
            List<Account> list = new List<Account>();
            string json = "";

            list = dbHandler.getAllAccs();
            System.Console.WriteLine("list in getallcontroller says " + list[0].getUserName());
            json = jsonHandler.serializeAccounts(list);

            return json;
        }        
    } 
}
