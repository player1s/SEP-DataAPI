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

            string Json = JsonConvert.SerializeObject(list);
            return Json;
        }

        public Account deSerializeAccount(string json)
        {
            Account account = (Account) JsonConvert.DeserializeObject(json);
            return account;
        }


    }
}