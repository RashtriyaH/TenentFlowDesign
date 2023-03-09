namespace TenentFlowDesign.View.Payment;

public partial class BankDetails : ContentPage
{
	public BankDetails()
	{
		InitializeComponent();
	}

    private async void OnBackToPayment(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }

    private async void OnTappedToNextPage(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new AddBankDetailsPage());
    }
}