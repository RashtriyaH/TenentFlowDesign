using System.Reflection.Metadata.Ecma335;

namespace TenentFlowDesign.View.MyTenancies;

public partial class MyTenanciesPage : ContentPage
{
	public MyTenanciesPage()
	{
		InitializeComponent();
    }

    private async void OnclickBackToMainPage(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
    private void OnTappedTOChangeTwo(object sender, EventArgs e)
    {
        btn2.BackgroundColor = Color.FromRgba(76, 175, 80, 0.3);
    }

    private void OnTappedTOChangeOne(object sender, EventArgs e)
    {
       btn1.BackgroundColor = Color.FromRgba(76, 175, 80, 0.3);
        if (sender is Button button)
        {
            button.IsEnabled = false;
            // the rest of the logic
            btn1.BackgroundColor = Color.FromRgb(76, 175, 80);
            
        }
      
    }
}