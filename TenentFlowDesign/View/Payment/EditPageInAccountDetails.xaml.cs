using TenentFlowDesign.ViewModel;

namespace TenentFlowDesign.View.Payment;

public partial class EditPageInAccountDetails : ContentPage
{
	public EditPageInAccountDetails()
	{
		InitializeComponent();
        BindingContext = new PaymentPageViewModel();
    }

  //  private async void OnClickToAccountPage(object sender, EventArgs e)
  //  {
		//await Navigation.PopAsync();
  //  }
}