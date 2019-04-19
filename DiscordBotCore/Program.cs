using DiscordBotCore.Discord;
using DiscordBotCore.Discord.Entities;
using System;

namespace DiscordBotCore
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Unity.RegisterTypes();
            Console.WriteLine("I think we can put our differences behind us. For science. You monster.");

            var discordBotConfig = new BotConfig()
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()
            };
            var connection = Unity.Resolve<Connection>();

            Console.ReadKey();
        }
    }
}
