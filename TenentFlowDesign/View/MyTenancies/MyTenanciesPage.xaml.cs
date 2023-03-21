using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using TenentFlowDesign.ViewModel;

namespace TenentFlowDesign.View.MyTenancies;

public partial class MyTenanciesPage : ContentPage
{
    public MyTenanciesPage()
    {
        InitializeComponent();
        BindingContext = new MyTenanciesViewModel();
    }
}



