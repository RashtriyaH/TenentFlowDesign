namespace TenentFlowDesign.View;

public partial class SupportHelpPage : ContentPage
{
	public SupportHelpPage()
	{
		InitializeComponent();
	}

    private async void OnclickBackToSettings(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}