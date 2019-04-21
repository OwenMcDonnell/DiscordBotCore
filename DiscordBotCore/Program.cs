using System.Threading.Tasks;

namespace DiscordBotCore
{
    internal static class Program
    {
        private static async Task Main()
        {
            var bot = Unity.Resolve<DiscordBot>();
            await bot.Start();
        }
    }
}
