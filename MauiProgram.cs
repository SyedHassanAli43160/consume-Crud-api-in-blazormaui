using Microsoft.AspNetCore.Components.WebView.Maui;
using consumeapiinblazormaui.Data;

namespace consumeapiinblazormaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Services.AddScoped<user>();
        builder.Services.AddScoped<HttpClient>();
        builder.Services.AddSingleton<WeatherForecastService>();
#endif


        return builder.Build();
	}
}
