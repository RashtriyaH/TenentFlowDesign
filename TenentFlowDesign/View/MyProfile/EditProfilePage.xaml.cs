using TenentFlowDesign.ViewModel;

namespace TenentFlowDesign.View.MyProfile;

public partial class EditProfilePage : ContentPage
{
    public EditProfilePage()
    {
        InitializeComponent();
        BindingContext = new CreateProfilePageViewModel();
    }

    private async void OnClickedAsync(object sender, EventArgs e)
    {
        try
        {
            var result = await FilePicker.PickAsync(new PickOptions
            {
                FileTypes = FilePickerFileType.Images
            });


            if (result == null)
                return;

            var stream = await result.OpenReadAsync();

            myimage.Source = ImageSource.FromStream(() => stream);
        }
        catch (Exception ex)
        {
            ex.ToString();
        }
    }
}