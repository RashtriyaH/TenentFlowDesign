namespace TenentFlowDesign.View.Payment;

public partial class EditPageInAccountDetails : ContentPage
{
	public EditPageInAccountDetails()
	{
		InitializeComponent();
	}

    private async void OnClickToAccountPage(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}