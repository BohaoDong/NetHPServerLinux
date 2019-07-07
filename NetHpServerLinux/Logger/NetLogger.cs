using System;

namespace NetHpServer.Logger
{
    public class NetLogger
    {
        public static Action<string> OnLogEvent;

        public static void Log(string message)
        {
            OnLogEvent?.Invoke(message);
        }
        public static void Log(string message, Exception exception)
        {
            NetHpServerLinux.Logger.Logger.Default.Error(message, exception);
        }
    }
}