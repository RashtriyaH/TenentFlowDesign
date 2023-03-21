using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TenentFlowDesign.ViewModel
{
    //public class MyTenanciesViewModel : INotifyPropertyChanged
    //{
    #region
    //    private Color _button1BackgroundColor = Colors.Transparent;
    //    private Color _button2BackgroundColor = Colors.Transparent;

    //    public Color Button1BackgroundColor
    //    {
    //        get { return _button1BackgroundColor; }
    //        set
    //        {
    //            if (_button1BackgroundColor != value)
    //            {
    //                _button1BackgroundColor = value;
    //                OnPropertyChanged(nameof(Button1BackgroundColor));
    //            }
    //        }
    //    }

    //    public Color Button2BackgroundColor
    //    {
    //        get { return _button2BackgroundColor; }
    //        set
    //        {
    //            if (_button2BackgroundColor != value)
    //            {
    //                _button2BackgroundColor = value;
    //                OnPropertyChanged(nameof(Button2BackgroundColor));
    //            }
    //        }
    //    }

    //    public ICommand Button1Command { get; }
    //    public ICommand Button2Command { get; }

    //    public MyTenanciesViewModel()
    //    {
    //        Button1Command = new Command(ToggleButton1BackgroundColor);
    //        Button2Command = new Command(ToggleButton2BackgroundColor);
    //    }

    //    private void ToggleButton1BackgroundColor()
    //    {
    //        if (Button1BackgroundColor == Colors.Transparent)
    //        {
    //            Button1BackgroundColor = Colors.Goldenrod;
    //        }
    //        else
    //        {
    //            Button1BackgroundColor = Colors.Transparent;
    //        }
    //    }

    //    private void ToggleButton2BackgroundColor()
    //    {
    //        if (Button2BackgroundColor == Colors.Transparent)
    //        {
    //            Button2BackgroundColor = Colors.Goldenrod;
    //        }
    //        else
    //        {
    //            Button2BackgroundColor = Colors.Transparent;
    //        }
    //    }


    //    #region My updated Code
    //    private List<ProfileField1> _fields = new List<ProfileField1>
    //{
    //    new ProfileField1("Mobile Number", "8277423414"),
    //    new ProfileField1("Email Id", "kai@1234gmail.com"),
    //    new ProfileField1("Age", "25")
    //};

    //    public List<ProfileField1> Fields
    //    {
    //        get { return _fields; }
    //        set
    //        {
    //            _fields = value;
    //            OnPropertyChanged("Fields");
    //        }
    //    }
    //}

    //public class ProfileField1
    //{
    //    public string Title { get; set; }
    //    public string Value { get; set; }

    //    public ProfileField1(string title, string value)
    //    {
    //        Title = title;
    //        Value = value;
    //    }
    //}
    //#endregion
    #endregion

    #region color change
    public class MyTenanciesViewModel : ObservableObject
    {
        private Color _button1BackgroundColor = Colors.Goldenrod;
        private Color _button2BackgroundColor = Colors.Transparent;
        private bool _isTitleVisible = false;
        private bool _isValueVisible = false;

        public Color Button1BackgroundColor
        {
            get { return _button1BackgroundColor; }
            set
            {
                SetProperty(ref _button1BackgroundColor, value);
                ToggleVisibility();
            }
        }

        public Color Button2BackgroundColor
        {
            get { return _button2BackgroundColor; }
            set
            {
                SetProperty(ref _button2BackgroundColor, value);
                ToggleVisibility();
            }
        }

        public bool IsTitleVisible
        {
            get { return _isTitleVisible; }
            set { SetProperty(ref _isTitleVisible, value); }
        }

        public bool IsValueVisible
        {
            get { return _isValueVisible; }
            set { SetProperty(ref _isValueVisible, value); }
        }

        public ICommand Button1Command { get; }
        public ICommand Button2Command { get; }

        public MyTenanciesViewModel()
        {
            Button1Command = new Command(ToggleButton1BackgroundColor);
            Button2Command = new Command(ToggleButton2BackgroundColor);
        }

        private void ToggleButton1BackgroundColor()
        {
            if (Button1BackgroundColor == Colors.Goldenrod)
            {
                Button1BackgroundColor = Colors.Transparent;
            }
            else
            {
                Button1BackgroundColor = Colors.Goldenrod;
            }
        }

        private void ToggleButton2BackgroundColor()
        {
            if (Button2BackgroundColor == Colors.Transparent)
            {
                Button2BackgroundColor = Colors.Goldenrod;
            }
            else
            {
                Button2BackgroundColor = Colors.Transparent;
            }
        }

        private void ToggleVisibility()
        {
            if (Button1BackgroundColor == Colors.Goldenrod && Button2BackgroundColor == Colors.Transparent)
            {
                IsTitleVisible = true;
                IsValueVisible = false;
            }
            else if (Button1BackgroundColor == Colors.Transparent && Button2BackgroundColor == Colors.Goldenrod)
            {
                IsTitleVisible = false;
                IsValueVisible = true;
            }
            else
            {
                IsTitleVisible = false;
                IsValueVisible = true;
            }
        }

        #region My updated Code
        private List<ProfileField1> _fields = new List<ProfileField1>
        {
            new ProfileField1("B4005,Imperial height", "Tata Promount"),
            new ProfileField1("Pooja Apartments", "Sobha Apartment"),
            new ProfileField1("Prestige", "Brigade Millenium")
        };

        public List<ProfileField1> Fields
        {
            get { return _fields; }
            set { SetProperty(ref _fields, value); }
        }
        #endregion

        private void SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = "", Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return;

            backingStore = value;

            onChanged?.Invoke();

            OnPropertyChanged(propertyName);
        }
    }

    public class ProfileField1 : ObservableObject
    {
        public string Title { get; set; }
        public string Value { get; set; }

        public ProfileField1(string title, string value, bool isTitleVisible = true, bool isValueVisible = false)
        {
            Title = title;
            Value = value;
            IsTitleVisible = isTitleVisible;
            IsValueVisible = isValueVisible;
        }

        public bool IsTitleVisible { get; set; }
        public bool IsValueVisible { get; set; }
    }
    #endregion

    #region toggling
    //public partial class MyTenanciesViewModel : ObservableObject
    //{
    //    [ObservableProperty]
    //    private string _updateType;

    //    [ObservableProperty]
    //    private List<string> _namesToggle; 
    //    [ObservableProperty]
    //    private List<string> _namesToggleTo; 
    //    [ObservableProperty]
    //    private List<string> _namesToggleButton; 

    //    public MyTenanciesViewModel()
    //    {
    //        NamesToggle = new List<string> { "B4005,Imperial height, Tata Promount" };
    //        NamesToggleTo = new List<string> { "B4005,Imperial height, Tata Promount" };
    //        NamesToggleButton = new List<string> { "B4005,Imperial height, Tata Promount" };
    //    }

    //    [RelayCommand]
    //    private void UpdateForMobile(string type)
    //    {
    //        UpdateType = type;
    //    }
    //}
    #endregion
}


