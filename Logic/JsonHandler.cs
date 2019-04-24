using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using SEP_DataAPI.Model;

namespace SEP_DataAPI.Logic
{
    public class JsonHandler
    {
        public string serializeAccounts(List<Account> list)
        {
            System.Console.WriteLine("list in JsonHandler says " +  list[0].getUserName());

            string Json = JsonConvert.SerializeObject(list);
            System.Console.WriteLine("converted thingy be like " + Json);
            return Json;
        }

        public Account deSerializeAccount(string json)
        {
            Account account = (Account) JsonConvert.DeserializeObject(json);
            return account;
        }


    }
}