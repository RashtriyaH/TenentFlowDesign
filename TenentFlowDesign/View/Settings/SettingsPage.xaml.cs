using TenentFlowDesign.View;
using TenentFlowDesign.ViewModel;

namespace TenentFlowDesign;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
        BindingContext=new TappedClassViewModel();
	}
}