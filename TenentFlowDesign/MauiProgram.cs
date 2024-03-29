﻿using Microsoft.Extensions.Logging;
using TenentFlowDesign;
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
		//View Settings
		builder.Services.AddSingleton<SettingsPage>();
		builder.Services.AddSingleton<NotificationsPage>();
		builder.Services.AddSingleton<SecurityAndPrivacy>();
		builder.Services.AddSingleton<SwitchProfile>();
		builder.Services.AddSingleton<HelpPage>();

		//View My Activity 
		builder.Services.AddSingleton<MyActivitiesPage>();
		builder.Services.AddSingleton<CommingSoonPage>();

        //View SecurityAndPrivacy
        builder.Services.AddTransient<CreateTransactionPage>();


#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
