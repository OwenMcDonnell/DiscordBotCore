using DiscordBotCore.Discord;
using DiscordBotCore.Discord.Entities;
using DiscordBotCore.Storage;
using System;
using System.Threading.Tasks;

namespace DiscordBotCore
{
    internal static class Program
    {
        static async Task Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("I think we can put our differences behind us. For science. You monster.");

            var storage = Unity.Resolve<IDataStorage>();        
            var connection = Unity.Resolve<Connection>();
            await connection.ConnectAsync(new BotConfig
            {
                Token = storage.RestoreObject<string>("Config/BotToken")
            });
        }
    }
}
