using TenentFlowDesign.ViewModel;

namespace TenentFlowDesign.View.MyProfile;

public partial class CreateProfilePage : ContentPage
{
	public CreateProfilePage()
	{
		InitializeComponent();
        BindingContext = new CreateProfilePageViewModel();
    }
}