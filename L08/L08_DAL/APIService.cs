using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace L08_DAL
{
    public class APIService
    {
        public async Task<Info> CallAPI()
        {
            HttpClient request = new HttpClient();
            var result = await request.GetStringAsync("http://testmyapi.azurewebsites.net/api/values/");
            var info=Newtonsoft.Json.JsonConvert.DeserializeObject<Info>(result);
            info.Json = result;
            return info;
        }
    }

    public class Info
    {
        public string Json { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Work { get; set; }
    }
}
