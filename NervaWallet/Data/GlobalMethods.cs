using NervaWallet.Services;

namespace NervaWallet.Data
{
    public static class GlobalMethods
    {
        public static void SetUpDataPaths()
        {
            try
            {
                // TODO: LocalApplicationDate does not currently work in MAUI. Need to revisit this. For now use AppDataDirectory

                // Set/create application data directory
                if (string.IsNullOrEmpty(GlobalData.AppDataPath))
                {
                    GlobalData.AppDataPath = FileSystem.AppDataDirectory;

                    //GlobalData.AppDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), GlobalData.AppName);
                    
                    //GlobalData.AppDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), GlobalData.AppName);
                }

                if (!Directory.Exists(GlobalData.AppDataPath))
                {
                    DirectoryInfo dir = Directory.CreateDirectory(GlobalData.AppDataPath);
                }


                // Set/create wallet directory
                if (string.IsNullOrEmpty(GlobalData.AppWalletsPath))
                {
                    GlobalData.AppWalletsPath = Path.Combine(GlobalData.AppDataPath, "Wallets");
                }

                if (!Directory.Exists(GlobalData.AppWalletsPath))
                {
                    DirectoryInfo dir = Directory.CreateDirectory(GlobalData.AppWalletsPath);
                }


                // Set up log file
                if (string.IsNullOrEmpty(GlobalData.AppLogFile))
                {
                    GlobalData.AppLogFile = Path.Combine(GlobalData.AppDataPath, "NervaWallet.log");

                    // If file already exists when application starts, copy it to old and delete original one
                    if(File.Exists(GlobalData.AppLogFile))
                    {
                        string destinationFile = Path.Combine(GlobalData.AppDataPath, "NervaWallet_old.log");
                        File.Copy(GlobalData.AppLogFile, destinationFile, true);

                        File.Delete(GlobalData.AppLogFile);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleException(ex, "GM.SADP", true);
            }
        }
    }
}