using DiscordBotCore.Storage;
using DiscordBotCore.Storage.Implementations;
using System;
using System.IO;
using Xunit;

namespace DiscordBotCore.xUnit.Tests
{
    public static class DataStorageTests
    {
        [Fact]
        public static void StorageDefaultsToJson()
        {
            var storage = Unity.Resolve<IDataStorage>();

            Assert.Throws<InvalidCastException>(() =>
            {
                var ims = (InMemoryStorage)storage;
            });

            var s = (JsonStorage)storage;
        }

        [Fact]
        public static void InMemoryStorageTest()
        {
            const string expected = "I'm a unit test!";
            const string expectedKey = "TEST";

            IDataStorage storage = new InMemoryStorage();

            storage.StoreObject("I'm different.", expectedKey);
            storage.StoreObject(expected, expectedKey);

            var actual = storage.RestoreObject<string>(expectedKey);

            Assert.Equal(expected, actual);
            Assert.Throws<ArgumentException>(() => storage.RestoreObject<object>("FAKE-KEY"));
        }

        [Fact]
        public static void JsonStorageTest()
        {
            const string expected = "I'm a unit test!";
            const string expectedKey = "xUnitTests/TEST";

            IDataStorage storage = new JsonStorage();

            storage.StoreObject(expected, expectedKey);

            var actual = storage.RestoreObject<string>(expectedKey);

            Assert.Equal(expected, actual);
            //Assert.Throws<FileNotFoundException>(() => storage.RestoreObject<object>("xUnitTests/FAKE-KEY"));
        }
    }
}
