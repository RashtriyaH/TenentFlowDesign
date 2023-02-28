namespace TenentFlowDesign;

public partial class NotificationsPage : ContentPage
{
	public NotificationsPage()
	{
		InitializeComponent();
	}

    private async void OnclickBackToSettings(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}