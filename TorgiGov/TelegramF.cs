using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTelegram;

namespace TorgiGov
{
    static internal class TelegramF
    {
        public static async Task Main()
        {
            using var client = new WTelegram.Client();
            var myself = await client.LoginUserIfNeeded();
            Console.WriteLine($"We are logged-in as {myself} (id {myself.id})");
        }
    }
}
