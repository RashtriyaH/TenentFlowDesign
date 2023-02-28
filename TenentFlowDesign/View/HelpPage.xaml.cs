namespace TenentFlowDesign.View;

public partial class HelpPage : ContentPage
{
	public HelpPage()
	{
		InitializeComponent();
	}

    private async void OnclickBackToSettings(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }

    private async void OnClickToSupportHelp(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SupportHelpPage());
    }
}