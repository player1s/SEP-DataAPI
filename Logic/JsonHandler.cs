using System.Collections;
using Newtonsoft.Json;
using SEP_DataAPI.Model;

namespace SEP_DataAPI.Logic
{
    public class JsonHandler
    {
        public string serializeAccounts(ArrayList list)
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