using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TenentFlowDesign.View;
using TenentFlowDesign.View.SecurityAndPrivacy;

namespace TenentFlowDesign.ViewModel
{
    public partial class TappedClassViewModel : ObservableObject
    {

        [RelayCommand]
        public async void TapCommandToMove(string param)
        {
            switch (param)
            {
                case "1":
                    await Application.Current.MainPage.Navigation.PushAsync(new NotificationsPage());
                    break;
                case "2":
                    await Application.Current.MainPage.Navigation.PushAsync(new SecurityAndPrivacy());
                    break;
                case "3":
                    await Application.Current.MainPage.Navigation.PushAsync(new SwitchProfile());
                    break;
                case "4":
                    await Application.Current.MainPage.Navigation.PushAsync(new HelpPage());
                    break;
                case "5":
                    await Application.Current.MainPage.Navigation.PushAsync(new SupportHelpPage());
                    break;
                case "6":
                    await Application.Current.MainPage.Navigation.PushAsync(new CreateTransactionPage());
                    break;
            }
        }
    }
}
