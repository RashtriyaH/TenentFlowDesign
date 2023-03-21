using TenentFlowDesign.ViewModel;

namespace TenentFlowDesign.View.Payment;

public partial class AddBankDetailsPage : ContentPage
{
	public AddBankDetailsPage()
	{
		InitializeComponent();
        BindingContext = new PaymentPageViewModel();
    }

    //private async void OnCLickToAccountPage(object sender, EventArgs e)
    //{
    //    await Navigation.PopAsync();
    //}

    //private async void OnCLickToEditPage(object sender, EventArgs e)
    //{
    //    await Navigation.PushAsync(new EditPageInAccountDetails());
    //}
}