using System;

using UWPContacts.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWPContacts.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }

        
    }
}
