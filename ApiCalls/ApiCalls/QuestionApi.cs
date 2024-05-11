using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace ApiCalls
{
    public class QuestionApi
    {
        public String GetQuestions( int _categorie, String dificultate, Boolean isAny = false )
        {
            if (isAny == false)
            {
                var httpClient = new HttpClient();
                var response = httpClient.GetAsync("https://opentdb.com/api.php?amount=10&category=" + _categorie + "&difficulty=" + dificultate + "&type=multiple").Result;
                byte[] responseBytes = response.Content.ReadAsByteArrayAsync().Result;
                var content = Encoding.UTF8.GetString(responseBytes);
                return content;
            }
            else
            {
                var httpClient = new HttpClient();
                var response = httpClient.GetAsync("https://opentdb.com/api.php?amount=20&category=" + _categorie + "&type=multiple").Result;
                byte[] responseBytes = response.Content.ReadAsByteArrayAsync().Result;
                var content = Encoding.UTF8.GetString(responseBytes);
                return content;
            }
        }
    }
}
