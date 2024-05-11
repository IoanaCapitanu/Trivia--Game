using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiCalls
{
    public class ApiCategory
    {
        public String GetCategories()
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync("https://opentdb.com/api_category.php").Result;

            var content = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Failed to retrieve trivia categories. Status code: " + response.StatusCode);
            }
            return content;

        }
    }
}
