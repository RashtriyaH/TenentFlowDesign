using TenentFlowDesign.ViewModel;

namespace TenentFlowDesign.View.MyActivity;

public partial class LastPage : ContentPage
{
	public LastPage()
	{
		InitializeComponent();
        BindingContext = new MyActivityPageViewModel();
    }
}