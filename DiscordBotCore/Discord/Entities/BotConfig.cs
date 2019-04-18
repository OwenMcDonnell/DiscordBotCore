using Discord.WebSocket;

namespace DiscordBotCore.Discord.Entities
{
    internal class BotConfig
    {
        public string Token { get; set; }
        public DiscordSocketConfig SocketConfig { get; set; }
    }
}
