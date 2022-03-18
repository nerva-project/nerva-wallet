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

namespace NervaWallet.Pages
{
    public partial class Settings
    {
        private void DebugFolder()
        {
            ProcessStartInfo psi = new ProcessStartInfo { FileName = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), UseShellExecute = true };
            //ProcessStartInfo psi = new ProcessStartInfo{FileName =  Path.Combine(Environment.GetEnvironmentVariable("HOME"), "NervaWallet"), UseShellExecute = true};
            Process.Start(psi);
        }
    }
}