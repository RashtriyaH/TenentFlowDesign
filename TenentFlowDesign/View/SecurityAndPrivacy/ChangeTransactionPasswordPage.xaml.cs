namespace TenentFlowDesign.View.SecurityAndPrivacy;

public partial class ChangeTransactionPasswordPage : ContentPage
{
	public ChangeTransactionPasswordPage()
	{
		InitializeComponent();
	}

    private async void OnCLickToChangePage(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }

    private async void OnCLickToChangeTransPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PwdPageOfChangeTransPage());
    }
}