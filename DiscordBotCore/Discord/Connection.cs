﻿using Discord;
using Discord.WebSocket;
using DiscordBotCore.Discord.Entities;
using System.Threading.Tasks;

namespace DiscordBotCore.Discord
{
    public class Connection
    {
        private readonly DiscordSocketClient _client;
        private readonly DiscordLogger _logger;

        public Connection(DiscordLogger logger, DiscordSocketClient client)
        {
            _logger = logger;
            _client = client;
        }

        public async Task ConnectAsync(BotConfig config)
        {
            _client.Log += _logger.Log;

            await _client.LoginAsync(TokenType.Bot, config.Token);
            await _client.StartAsync();
            await Task.Delay(-1).ConfigureAwait(false);        
        }
    }
}
