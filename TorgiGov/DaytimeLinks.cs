using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TorgiGov
{
    internal class DaytimeLinks
    {
        static HttpClient httpClient = new HttpClient();

        public async Task<List<string>> ProcessingDailyLinks(string link)
        {
            List<string> links = new List<string>();
            var jsonElement = await JsonLinks.ProcessingJsonLinks(link);

            JsonElement element;
            var el1 = jsonElement.TryGetProperty("listObjects", out element);
            if (el1 != true)
                return links;

            //var arrayJson = jsonElement.GetProperty("listObjects");

            

            for (int i = 0; i < element.GetArrayLength(); i++)
            {
                var href = element[i].GetProperty("href").GetString();
                links.Add(href);
            }
            return links;
        }
    }
}
