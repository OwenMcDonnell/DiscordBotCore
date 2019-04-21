using Discord;
using Discord.WebSocket;
using DiscordBotCore.Discord;
using Xunit;

namespace DiscordBotCore.xUnit.Tests
{
    public class SocketConfigTests
    {
        [Fact]
        public static void ConfigGetDefaultTest()
        {
            const LogSeverity expected = LogSeverity.Verbose;

            var actual = SocketConfig.GetDefault().LogLevel;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void ConfigGetNewTest()
        {
            var actual = SocketConfig.GetNew();

            Assert.NotNull(actual);
            Assert.IsType<DiscordSocketConfig>(actual);
        }
    }
}
