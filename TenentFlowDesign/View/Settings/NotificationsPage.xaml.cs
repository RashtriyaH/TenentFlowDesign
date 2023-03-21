using TenentFlowDesign.ViewModel;

namespace TenentFlowDesign;

public partial class NotificationsPage : ContentPage
{
	public NotificationsPage()
	{
		InitializeComponent();
        BindingContext = new TappedClassViewModel();
    }

   
}