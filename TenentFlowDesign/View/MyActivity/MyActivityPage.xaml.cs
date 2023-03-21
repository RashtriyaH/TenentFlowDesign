using TenentFlowDesign.ViewModel;

namespace TenentFlowDesign.View.MyActivity;

public partial class MyActivityPage : ContentPage
{
	public MyActivityPage()
	{
		InitializeComponent();
        BindingContext = new MyActivityPageViewModel();
    }
    //private async void OnclickBackToMainPage(object sender, EventArgs e)
    //{
    //    await Navigation.PopAsync();
    //}

    //private async void OnTappedToNextPage(object sender, TappedEventArgs e)
    //{
    //    await Navigation.PushAsync(new LastPage());
    //}
}