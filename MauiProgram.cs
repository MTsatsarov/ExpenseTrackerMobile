using ExpenseTrackerMobile.Services;
using ExpenseTrackerMobile.Services.Interfaces;
using ExpenseTrackerMobile.ViewModels;

namespace ExpenseTrackerMobile;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		//Services
		builder.Services.AddTransient<IAccountService, AccountService>();

		//ViewModels
		builder.Services.AddSingleton<MainPageViewModel>();

		//Pages
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<RegisterPage>();
		return builder.Build();
	}
}
