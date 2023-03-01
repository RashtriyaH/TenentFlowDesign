using TenentFlowDesign.ViewModel;

namespace TenentFlowDesign;

public partial class SecurityAndPrivacy : ContentPage
{
	public SecurityAndPrivacy()
	{
		InitializeComponent();
        BindingContext = new TappedClassViewModel();
    }

    private async void OnclickBackToSettings(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}