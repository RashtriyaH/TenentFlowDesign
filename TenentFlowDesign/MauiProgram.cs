using Microsoft.Extensions.Logging;
using TenentFlowDesign;
using TenentFlowDesign.View;
using TenentFlowDesign.View.MyProfile;
using TenentFlowDesign.View.MyTenancies;
using TenentFlowDesign.View.Payment;
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
        builder.Services.AddTransient<PaymentPageViewModel>();


        //View
        //View Settings
        builder.Services.AddSingleton<SettingsPage>();

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


		//View My Activity 
		builder.Services.AddSingleton<MyActivitiesPage>();
		builder.Services.AddSingleton<CommingSoonPage>();


        //View SecurityAndPrivacy
        builder.Services.AddTransient<CreateTransactionPage>();
        builder.Services.AddTransient<ChangeTransactionPasswordPage>();
        builder.Services.AddTransient<PasswordPageOfTransactionPage>();
        builder.Services.AddTransient<PwdPageOfChangeTransPage>();
        

        //view MyProfilePage
        builder.Services.AddTransient<CreateProfilePage>();
		builder.Services.AddSingleton<EditProfilePage>();
		builder.Services.AddSingleton<NotificationPage>();

        //View MyTenancies
        builder.Services.AddSingleton<MyTenanciesPage>();

        //View Payment
        builder.Services.AddSingleton<BankDetails>();
        builder.Services.AddSingleton<AddBankAccountPage>();
        builder.Services.AddSingleton<EditPageInAccountDetails>();
        builder.Services.AddSingleton<UpdatingTheAccountPage>();
        builder.Services.AddSingleton<AddBankDetailsPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
