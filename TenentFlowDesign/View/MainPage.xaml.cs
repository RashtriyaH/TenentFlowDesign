using TenentFlowDesign.View;
using TenentFlowDesign.View.MyTenancies;
using TenentFlowDesign.View.Payment;

namespace TenentFlowDesign;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnTapGestureRecognizerTapped(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new SettingsPage());
    }

    private async void OnTapGestureToOtherPage(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new MyActivitiesPage());
    }

    private async void OnTapGestureToMyTenanciesPage(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new MyTenanciesPage());
    }

    private async void OnTapGestureToMyPaymentsPage(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new BankDetails());
    }
}

