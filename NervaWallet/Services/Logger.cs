using NervaWallet.Data;
using Serilog;

namespace NervaWallet.Services
{
    public static class Logger
    {
		public static void InitializeLog()
		{
			LogInfo("LOG.INIT", "Nerva Wallet. Version: " + "TODO: Write version here");
			LogInfo("LOG.INIT", "System Information:");
			LogInfo("LOG.INIT", "OS: " + Environment.OSVersion.Platform + " " + Environment.OSVersion.Version);
			LogInfo("LOG.INIT", "CPU Count: " + Environment.ProcessorCount);
			LogInfo("LOG.INIT", "Writing log to file: " +  GlobalData.AppLogFile);
		}

        #region Debug Logging
        public static void LogDebug(string message)
        {
            Log.Debug(message);
        }

        public static void LogDebug(string origin, string message)
        {
            Log.Debug(origin + "\t " + message);
        }
        #endregion // Debug Logging

        #region Info Logging
        public static void LogInfo(string message)
        {
            Log.Information(message);
        }

        public static void LogInfo(string origin, string message)
        {
            Log.Information(origin + "\t " + message);
        }
        #endregion // Info Logging

        #region Error Logging
        public static void LogError(string message)
        {
            Log.Error(message);
        }

        public static void LogError(string origin, string message)
        {
            Log.Error(origin + "\t " + message);
        }
        #endregion // Error Logging

        #region Exception Logging
        public static void LogException(Exception exception)
        {
            LogError("Ex Msg: " + exception.Message + "\nTrace: " + exception.StackTrace);
        }

        public static void LogException(Exception exception, string origin)
        {
            LogError(origin, "Ex Msg: " + exception.Message + "\nTrace: " + exception.StackTrace);
        }

        public static void LogException(Exception exception, string origin, string message)
        {
            LogError(origin + "\t " + message, "Ex Msg: " + exception.Message + "\nTrace: " + exception.StackTrace);
        }
        #endregion // Exception Logging
    }
}