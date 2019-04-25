using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System;
using System.Collections.Generic;

namespace SEP_DataAPI.Logic
{
    class ClientToBridgeApp
    {
        public ClientToBridgeApp() { }
        
        public async void GetShutLED()
        {
            string url = "https://localhost:5001/api/login/";
            HttpClient client = new HttpClient();
            await client.GetAsync(url).ConfigureAwait(false);
        }  
    }
}
