using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TenentFlowDesign.View.MyActivity;
using TenentFlowDesign.View.MyProfile;
using TenentFlowDesign.View.MyTenancies;
using TenentFlowDesign.View.Payment;

namespace TenentFlowDesign.ViewModel
{
    public partial class MainPageViewModel : ObservableObject
    {
        [RelayCommand]
        public async void MoveFromMainToSubPage(string param)
        {
            switch (param)
            {
                case "1":
                    await Application.Current.MainPage.Navigation.PushAsync(new SettingsPage());
                    break;
                case "2":
                    await Application.Current.MainPage.Navigation.PushAsync(new MyActivityPage());
                    break;
                case "3":
                    await Application.Current.MainPage.Navigation.PushAsync(new MyTenanciesPage());
                    break;
                case "4":
                    await Application.Current.MainPage.Navigation.PushAsync(new BankDetails());
                    break;
                case "5":
                    await Application.Current.MainPage.Navigation.PushAsync(new CreateProfilePage());
                    break;
            }
        }
    }
}
