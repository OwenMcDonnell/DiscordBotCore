using Discord.Net;
using DiscordBotCore.Discord;
using DiscordBotCore.Discord.Entities;
using System.Threading.Tasks;
using Xunit;

namespace DiscordBotCore.xUnit.Tests
{
    public class ConnectionTests
    {
        [Fact]
        public void ConnectionAsyncTest()
        {
            Assert.ThrowsAsync<HttpException>(() => AttemptWrongConnect());
        }

        private static async Task AttemptWrongConnect()
        {
            var conn = Unity.Resolve<Connection>();

            await conn.ConnectAsync(new BotConfig { Token = "FAKE-TOKEN" });
        }
    }
}
