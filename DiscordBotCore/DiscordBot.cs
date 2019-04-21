using DiscordBotCore.Discord;
using DiscordBotCore.Discord.Entities;
using DiscordBotCore.Storage;
using System;
using System.Threading.Tasks;

namespace DiscordBotCore
{
    public class DiscordBot
    {
        private readonly IDataStorage _storage;
        private readonly Connection _connection;

        public DiscordBot(IDataStorage storage, Connection connection)
        {
            _storage = storage;
            _connection = connection;
        }

        public async Task Start()
        {
            Console.WriteLine("I think we can put our differences behind us. For science. You monster.");
           
            await _connection.ConnectAsync(new BotConfig
            {
                Token = _storage.RestoreObject<string>("Config/BotToken")
            });
        }
    }
}
