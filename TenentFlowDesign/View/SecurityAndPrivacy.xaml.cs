namespace TenentFlowDesign;

public partial class SecurityAndPrivacy : ContentPage
{
	public SecurityAndPrivacy()
	{
		InitializeComponent();
	}

    private async void OnclickBackToSettings(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}