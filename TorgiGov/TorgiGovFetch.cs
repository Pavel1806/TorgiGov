
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TorgiGov
{
    internal class TorgiGovFetch
    {
        static HttpClient httpClient = new HttpClient();
        public async Task FatchDate()
        {
            using var response = await httpClient.GetAsync("https://torgi.gov.ru/new/opendata/7710568760-notice/data-20230106T0000-20230107T0000-structure-20220401.json");
            
            //if (response != null)
            //{
            //    TorgiObject? notification = await response.Content.ReadFromJsonAsync<TorgiObject>();
                
            //    foreach (Notification obj in notification.ListObjects)
            //    {
            //            Console.WriteLine(obj.Href);
            //    }
                
            //}
        }

        public async Task<string> FatchNotification()
        {
            using var response =
                (await httpClient.GetAsync("https://torgi.gov.ru/new/opendata/7710568760-notice/docs/notice_21000026690000000009_30aa0a5c-bd74-4280-a21e-db6c20c87678.json")).EnsureSuccessStatusCode();

            var notification = await response.Content.ReadAsStringAsync();

            using var jsonDocument = JsonDocument.Parse(notification);

            var jsonRoot = jsonDocument.RootElement;

            return FromJsonElement(jsonRoot);
        }

        string FromJsonElement(JsonElement jsonElement)
        {
            var href = jsonElement
                .GetProperty("exportObject")
                .GetProperty("structuredObject")
                .GetProperty("notice")
                .GetProperty("commonInfo").GetProperty("href")
                .GetString();
            //var imdb = jsonElement
            //    .GetProperty("Rating")
            //    .GetProperty("Imdb")
            //    .GetDouble();
            //var rotten = jsonElement
            //    .GetProperty("Rating")
            //    .GetProperty("Rotten Tomatoes")
            //    .GetDouble();
            return href;
        }


























    }
}
