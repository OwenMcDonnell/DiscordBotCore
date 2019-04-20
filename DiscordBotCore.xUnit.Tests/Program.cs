using Xunit;

namespace DiscordBotCore.xUnit.Tests
{
    public static class UtilityTests
    {
        [Fact]
        public static void MyFirstTest()
        {
            const int expected = 5;

            var actual = Utilities.MyUtility(expected);

            Assert.Equal(expected, actual);
        }
    }
}
