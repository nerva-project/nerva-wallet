namespace NervaWallet.Services
{
    public static class ErrorHandler
    {
        public static void HandleException(Exception exception, string origin, bool showMessage)
        {
            HandleException(exception, origin, string.Empty, showMessage);
        }

        public static void HandleException(Exception exception, string origin, string message, bool showMessage)
        {
            try
            {
                Logger.LogException(exception, origin + message);
                if (showMessage)
                {
                    App.Current.MainPage.DisplayAlert("File Content", exception.Message, "OK");
                }
            }
            catch (Exception ex)
            {
                Logger.LogException(ex, "Failed while handling exception");
                // Exception handling failed.  Not much you can do.  Just try to continue.
                ex.Data.Clear();
            }
        }
    }
}