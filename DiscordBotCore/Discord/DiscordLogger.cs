﻿using Discord;
using System.Threading.Tasks;

namespace DiscordBotCore.Discord
{
    public class DiscordLogger
    {
        readonly ILogger _logger;

        public DiscordLogger(ILogger logger)
        {
            _logger = logger;
        }

        public Task Log(LogMessage logMsg)
        {
            _logger.Log(logMsg.Message);
            return Task.CompletedTask;
        }
    }
}
