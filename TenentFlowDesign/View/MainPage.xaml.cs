using TenentFlowDesign.ViewModel;

namespace TenentFlowDesign;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainPageViewModel();
    }
}

