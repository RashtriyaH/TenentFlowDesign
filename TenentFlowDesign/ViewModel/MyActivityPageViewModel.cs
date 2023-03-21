using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenentFlowDesign.View.MyActivity;

namespace TenentFlowDesign.ViewModel
{
    public partial class MyActivityPageViewModel : ObservableObject
    {
        [RelayCommand]
        public async void MyActivityPageToMove(string param)
        {
            switch (param)
            {
                case "1":
                    await Application.Current.MainPage.Navigation.PushAsync(new LastPage());
                    break;
                case "2":
                    await Application.Current.MainPage.Navigation.PushAsync(new MyActivityPage());
                    break;
                case "3":
                    await Application.Current.MainPage.Navigation.PopToRootAsync();
                    break;
            }
        }
    }
}
