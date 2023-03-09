namespace TenentFlowDesign.View.Payment;

public partial class AddBankAccountPage : ContentPage
{
	public AddBankAccountPage()
	{
		InitializeComponent();
	}

    private async void OnCLickToAccountPage(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}