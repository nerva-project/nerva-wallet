using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.JSInterop;
using NervaWallet;
using NervaWallet.Shared;
using System.Diagnostics;
using NervaWallet.Data;
using NervaWallet.Services;

namespace NervaWallet.Pages
{
    public partial class Settings
    {
        private void DebugFolder()
        {
            try
            {
                // TODO: For testing only: Create file if it does not exist 
                string file = Path.Combine(GlobalData.AppDataPath, "nerva.txt");
                if(!File.Exists(file))
                {
                    File.Create(file);
                }


                // TODO: For testing only: Append to file
                using (var stream = File.AppendText(file))
                {
                    stream.WriteLine("Opening Debug folder for: " + Environment.OSVersion.VersionString);
                }


                // TODO: For testing only: Read content of file into message box
                using (var stream = File.OpenRead(file))
                {
                    using(var streamReader = new StreamReader(stream))
                    {
                        App.Current.MainPage.DisplayAlert("File Content", streamReader.ReadToEnd(), "OK");
                    }                    
                }
                

                // Call platform specific version
                FileManager fileManager = new FileManager();
                fileManager.OpenDirectory(GlobalData.AppDataPath);
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleException(ex, "SET.DBF", true);
            }            
        }
    }
}