using DiscordBotCore.Discord;
using DiscordBotCore.Discord.Entities;
using DiscordBotCore.Storage;
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
            await _connection.ConnectAsync(new BotConfig
            {
                Token = _storage.RestoreObject<string>("Config/BotToken")
            });
        }
    }
}
