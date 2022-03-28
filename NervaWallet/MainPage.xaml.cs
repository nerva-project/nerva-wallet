using NervaWallet.Data;

namespace NervaWallet;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		GlobalMethods.CreateAppDataPathIfMissing();
	}
}
