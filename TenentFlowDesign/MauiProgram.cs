using Microsoft.Extensions.Logging;
using TenentFlowDesign.Controls;
using TenentFlowDesign.View;
using TenentFlowDesign.View.SecurityAndPrivacy;
using TenentFlowDesign.ViewModel;

namespace TenentFlowDesign;

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

        //ViewModel
        builder.Services.AddTransient<TappedClassViewModel>();

		//View
		builder.Services.AddSingleton<SettingsPage>();
		builder.Services.AddSingleton<NotificationsPage>();
		builder.Services.AddSingleton<SecurityAndPrivacy>();
		builder.Services.AddSingleton<SwitchProfile>();
		builder.Services.AddSingleton<HelpPage>();

		//SecurityAndPrivacy
        builder.Services.AddTransient<CreateTransactionPage>();


#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
