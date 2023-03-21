using TenentFlowDesign.ViewModel;

namespace TenentFlowDesign.View.MyProfile;

public partial class NotificationPage : ContentPage
{
	public NotificationPage()
	{
		InitializeComponent();
		BindingContext = new CreateProfilePageViewModel();
    }
}