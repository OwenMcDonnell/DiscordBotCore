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
            Console.WriteLine("Hello World!");
            var discordBotConfig = new BotConfig()
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()
            };
        }
    }
}
