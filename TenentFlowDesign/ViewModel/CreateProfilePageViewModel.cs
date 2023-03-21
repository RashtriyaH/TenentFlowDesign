using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TenentFlowDesign.View.MyProfile;

namespace TenentFlowDesign.ViewModel
{
    public partial class CreateProfilePageViewModel : ObservableObject
    {
        #region My code

        //List<string> _values = new List<string> { "8277423414", "kai@1234gmail.com", "25", "kim sobin", "single", "singer dancer" };
        //public List<string> Values
        //{
        //    get { return _values; }
        //    set
        //    {
        //        _values = value;
        //        OnPropertyChanged("Values");
        //    }
        //}

        #endregion

        #region My updated Code
        //    private List<ProfileField> _fields = new List<ProfileField>
        //{
        //    new ProfileField("Mobile Number", "8277423414"),
        //    new ProfileField("Email Id", "kai@1234gmail.com"),
        //    new ProfileField("Age", "25"),
        //    new ProfileField("Father Name", "kim sobin"),
        //    new ProfileField("Spouse Name/Single", "single"),
        //    new ProfileField("Occupation", "singer dancer")
        //};

        //    public List<ProfileField> Fields
        //    {
        //        get { return _fields; }
        //        set
        //        {
        //            _fields = value;
        //            OnPropertyChanged("Fields");
        //        }
        //    }
        //}

        //public class ProfileField
        //{
        //    public string Title { get; set; }
        //    public string Value { get; set; }

        //    public ProfileField(string title, string value)
        //    {
        //        Title = title;
        //        Value = value;
        //    }
        //}
        #endregion

        [ObservableProperty]
        private long _mobilenum;
        [ObservableProperty]
        private string _email;
        [ObservableProperty]
        private int _age;
        [ObservableProperty]
        private string _fathername;
        [ObservableProperty]
        private string _spouse;
        [ObservableProperty]
        private string _occupation;
        [ObservableProperty]
        private bool _popupVisible;
        [ObservableProperty]
        private string _updateType;
        //[ObservableProperty]
        //private sbyte myimage;
        public CreateProfilePageViewModel()
        {
            Mobilenum = 8277423414;
            Email = "kai@099gmail.com";
            Age = 25;
            Fathername = "kim sobin";
            Spouse = "Single";
            Occupation = "singer and dancer";

        }

        [RelayCommand]
        private void UpdateForMobile(string type)
        {

            UpdateType = type;
            PopupVisible = true;
        }

        //     private async void OnClickedAsync(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var result = await FilePicker.PickAsync(new PickOptions
        //        {
        //            FileTypes = FilePickerFileType.Images
        //        });
        //        if (result == null)
        //            return;

        //        var stream = await result.OpenReadAsync();

        //        myimage.Source = ImageSource.FromStream(() => stream);
        //    }
        //    catch (Exception ex)
        //    {
        //        ex.ToString();
        //    }

        //}

        [RelayCommand]
        public async void MoveFromProfileToSubPage(string param)
        {
            switch (param)
            {
                case "1":
                    await Application.Current.MainPage.Navigation.PopAsync();
                    break;
                case "2":
                    await Application.Current.MainPage.Navigation.PushAsync(new EditProfilePage());
                    break;
                case "3":
                    await Application.Current.MainPage.Navigation.PushAsync(new NotificationPage());
                    break;
                case "4":
                    await Application.Current.MainPage.Navigation.PopToRootAsync();
                    break;
            }
        }
    }
}
