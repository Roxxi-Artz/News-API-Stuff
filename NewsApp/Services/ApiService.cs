using NewsApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Services
{
    public class ApiService
    {
        public async Task<Root> GetNews()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://gnews.io/api/v4/top-headlines?token=b982d51a048be605486f758ab3da580e&topic=breaking-news&lang=en&topic=sports");

            //deserialization
            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
}
