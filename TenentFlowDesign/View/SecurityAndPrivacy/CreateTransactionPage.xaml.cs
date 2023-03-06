namespace TenentFlowDesign.View.SecurityAndPrivacy;

public partial class CreateTransactionPage : ContentPage
{
	public CreateTransactionPage()
	{
		InitializeComponent();
	}

    private async void OnCLickToEndPage(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new PasswordPageOfTransactionPage());
    }

    private async void OnClickToCreatePage(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}