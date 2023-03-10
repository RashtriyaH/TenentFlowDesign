namespace TenentFlowDesign.View.MyProfile;

public partial class CreateProfilePage : ContentPage
{
	public CreateProfilePage()
	{
		InitializeComponent();
	}

    private async void OnClickToProfilePage(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }

    private async void OnClicktoEditPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EditProfilePage());  
    }
}