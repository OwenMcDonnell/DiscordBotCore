using System;
using Xunit;

namespace DiscordBotCore.xUnit.Tests
{
    public class LoggerTests
    {
        [Fact]
        public void BasickLoggerTest()
        {
            var logger = Unity.Resolve<ILogger>();

            Assert.NotNull(logger);

            logger.Log("Hello, World!");

            Assert.Throws<ArgumentException>(() => logger.Log(null));
        }
    }
}
