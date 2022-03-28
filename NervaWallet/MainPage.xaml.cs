using NervaWallet.Services;

namespace NervaWallet;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
        try
        {
            InitializeComponent();
        }
        catch (Exception ex)
        {
            ErrorHandler.HandleException(ex, "MP.CONST", false);
        }
	}
}