namespace TenentFlowDesign.View;

public partial class MyActivitiesPage : ContentPage
{
	public MyActivitiesPage()
	{
		InitializeComponent();
	}

    private async void OnclickBackToMainPage(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
    private async void OnTappedToNextPage(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new CommingSoonPage());
    }
}