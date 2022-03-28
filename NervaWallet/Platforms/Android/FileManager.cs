using Android.Content;

namespace NervaWallet.Services
{
    public partial class FileManager
    {
        public partial void OpenDirectory(string path)
        {            
            var intent = new Intent(Intent.ActionView);            
            //intent.AddCategory(Intent.CategoryLauncher);                        
            intent.AddFlags(ActivityFlags.NewTask);


            // TODO: This opens downloads folder so the path is not working
            var uri = Android.Net.Uri.Parse(path);

            //var uri = Android.Net.Uri.Parse(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));

            //string package_name = "one.nerva.nervawallet";
            //var uri = Android.Net.Uri.FromParts("files", package_name, null);



            //intent.SetType("*/*");
            //intent.SetData(uri);

            intent.SetDataAndType(uri, "*/*");
            

            Android.App.Application.Context.StartActivity(intent);
        }
    }
}