namespace NervaWallet.Data
{
    public static class GlobalMethods
    {
        public static string GetAppDataPath()
        {
            try
            {                               
                return FileSystem.AppDataDirectory;

                //return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), GlobalData.AppName);

                // TODO: LocalApplicationDate does not currently work.  For now use above
                //return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), GlobalData.AppName);
            }
            catch (Exception ex)
            {
                // TODO: Add exception handling
                throw;
            }
        }

        public static void CreateAppDataPathIfMissing()
        {
            try
            {
                if(string.IsNullOrEmpty(GlobalData.AppDataPath))
                {
                    GlobalData.AppDataPath = GetAppDataPath();
                }

                if(!Directory.Exists(GlobalData.AppDataPath))
                {
                    DirectoryInfo dir = Directory.CreateDirectory(GlobalData.AppDataPath);
                }
            }
            catch (Exception ex)
            {
                // TODO: Add exception handling
                throw;
            }
        }
    }
}