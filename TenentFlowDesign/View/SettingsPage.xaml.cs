using TenentFlowDesign.View;

namespace TenentFlowDesign;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}

    private async void OnclickBack(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }

    private async void OnClickToNotification(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NotificationsPage());
    }

    private async void OnClickToSecurity(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SecurityAndPrivacy());
    }

    private async void OnClickToSwitchProfile(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SwitchProfile());
    }

    private async void OnClickToHelp(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HelpPage());
    }
}