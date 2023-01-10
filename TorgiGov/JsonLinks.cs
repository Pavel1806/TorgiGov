using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TorgiGov
{
    static internal class JsonLinks
    {
        static HttpClient httpClient = new HttpClient();
        static public async Task<JsonElement> ProcessingJsonLinks(string link)
        {
            var response = (await httpClient.GetAsync(link)).EnsureSuccessStatusCode();

            var notification = await response.Content.ReadAsStringAsync();

            var jsonDocument = JsonDocument.Parse(notification);

            var t = jsonDocument.RootElement;

            return t;
        }
    }
}
