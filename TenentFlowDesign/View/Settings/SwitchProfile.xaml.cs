namespace TenentFlowDesign.View;

public partial class SwitchProfile : ContentPage
{
	public SwitchProfile()
	{
		InitializeComponent();
	}

    private async void OnclickBackToSettings(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}