using TenentFlowDesign.View;

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
}

