using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace SwipeGesture
{
    public partial class MainPage : ContentPage
    {
        public ICommand NavigateCommand { get; private set; }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new SwipeCommandPageViewModel();
         
        }
    }
}
