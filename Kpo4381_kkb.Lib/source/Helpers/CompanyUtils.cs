using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.Lib
{
    public static class CompanyUtils
    {
        public static string GetGlobalCompanyName(List<Company> companees)
        {
            string result = "";

            foreach (Company company in companees)
            {
                result += company.Name;
            }
            return result;
        }

        public static double GetProfitFromEveryChar(Company company)
        {
            return company.Sales / company.Name.Length;
        }
        
        public static string GetCompleteInfo()
        {
            /*Этот метод возвращает актуальную информацию по состоянию интересных фактов о семействе кошачих на текущий момент времени
             */
            HttpClient client = new HttpClient();
            //Создать клиент для запроса к API
            HttpResponseMessage response = client.GetAsync("https://cat-fact.herokuapp.com/facts/random").Result;
            //Сформировать запрос
            response.EnsureSuccessStatusCode();
            string responseBody = response.Content.ReadAsStringAsync().Result;
            var data = (JObject)JsonConvert.DeserializeObject(responseBody);
            //Получить необходимые данные из ответа
            return (string)data["text"];
            //Вернуть актуальную информацию по состоянию интересных фактов о семействе кошачих на текущий момент времени

        }

        public static Company WhoAmI(Company company)
        {
            return company;
        }
    }
}
