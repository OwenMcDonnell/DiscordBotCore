using System;
using Xunit;

namespace DiscordBotCore.xUnit.Tests
{
    public static class LoggerTests
    {
        [Fact]
        public static void BasickLoggerTest()
        {
            var logger = Unity.Resolve<ILogger>();

            Assert.NotNull(logger);

            logger.Log("Hello, World!");

            Assert.Throws<ArgumentException>(() => logger.Log(null));
        }
    }
}
