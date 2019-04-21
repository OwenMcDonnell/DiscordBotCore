using System;

namespace DiscordBotCore
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            if (message == null)
            {
                throw new ArgumentException("Message cannot be null.");
            }

            Console.WriteLine(message);
        }
    }
}
