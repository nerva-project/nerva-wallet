using System.Diagnostics;

namespace NervaWallet.Services
{
    public partial class FileManager
    {
        public partial void OpenDirectory(string path)
        {
            ProcessStartInfo psi = new ProcessStartInfo { FileName = path, UseShellExecute = true };
            Process.Start(psi);
        }
    }
}