using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenentFlowDesign.View.Payment;

namespace TenentFlowDesign.ViewModel
{
    public partial class PaymentPageViewModel  : ObservableObject
    {
        [RelayCommand]
        public async void TapCommandToMove(string param)
        {
            switch (param)
            {
                case "1":
                    await Application.Current.MainPage.Navigation.PushAsync(new AddBankAccountPage());
                    break;
                case "2":
                    await Application.Current.MainPage.Navigation.PushAsync(new UpdatingTheAccountPage());
                    break;
            }
        }
    }
}
