using Foundation;
using UIKit;

namespace NervaWallet.Services
{
    public partial class FileManager
    {
        public partial void OpenDirectory(string path)
        {
            // TODO: Below is not working
            var url = NSUrl.FromString(path);
            //var url = new NSUrl($"shareddocuments:");
            //var url = new NSUrl(path);

            UIApplication.SharedApplication.OpenUrl(url);
        }
    }
}