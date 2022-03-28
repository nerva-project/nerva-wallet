using Microsoft.AspNetCore.Components.WebView.Maui;
using NervaWallet.Data;
using NervaWallet.Services;
using Serilog;

namespace NervaWallet;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		// Need paths before logging can be set up
		GlobalMethods.SetUpDataPaths();

		// Set up logger
		Log.Logger = new LoggerConfiguration()
			 .Enrich.FromLogContext()
			 .WriteTo.File(path: GlobalData.AppLogFile)
			 .CreateLogger();

		Logger.InitializeLog();

		var builder = MauiApp.CreateBuilder();
		builder
			.RegisterBlazorMauiWebView()
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddBlazorWebView();
		builder.Services.AddSingleton<WeatherForecastService>();
		builder.Services.AddLogging(logging =>
		{
			logging.AddSerilog(dispose: true);
		});

		return builder.Build();
	}
}
