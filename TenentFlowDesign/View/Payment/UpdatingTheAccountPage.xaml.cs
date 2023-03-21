using TenentFlowDesign.ViewModel;

namespace TenentFlowDesign.View.Payment;

public partial class UpdatingTheAccountPage : ContentPage
{
	public UpdatingTheAccountPage()
	{
		InitializeComponent();
        BindingContext = new PaymentPageViewModel();
    }

  //  private async void OnCLickToAccountPage(object sender, EventArgs e)
  //  {
		//await Navigation.PopAsync();
  //  }
}