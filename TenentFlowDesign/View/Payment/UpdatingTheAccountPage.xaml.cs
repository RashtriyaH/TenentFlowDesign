namespace TenentFlowDesign.View.Payment;

public partial class UpdatingTheAccountPage : ContentPage
{
	public UpdatingTheAccountPage()
	{
		InitializeComponent();
	}

    private async void OnCLickToAccountPage(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}