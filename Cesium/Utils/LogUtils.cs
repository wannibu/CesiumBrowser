using log4net;
using System;

namespace Cesium.Utils
{
    public static class LogUtils
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        public static void Debug(string message)
        {
            log.Debug(message);
        }

        public static void Info(string message)
        {
            log.Info(message);
        }

        public static void Warn(string message)
        {
            log.Warn(message);
        }

        public static void Error(string message)
        {
            log.Error(message);
        }

        public static void Fatal(string message)
        {
            log.Fatal(message);
        }

        public static void Error(string message, Exception ex)
        {
            log.Error(message, ex);
        }

        public static void Fatal(string message, Exception ex)
        {
            log.Fatal(message, ex);
        }

    }
}
