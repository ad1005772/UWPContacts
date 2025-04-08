using System;

using UWPContacts.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UWPContacts.Views
{
    public sealed partial class MainPage : Page
    {
        public ContactsViewModel ViewModel { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            ViewModel = new ContactsViewModel();
            this.DataContext = ViewModel;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ViewModel.NewContact.Name) && !string.IsNullOrWhiteSpace(ViewModel.NewContact.PhoneNumber))
            {
                ViewModel.Contacts.Add(new Contact { Name = ViewModel.NewContact.Name, PhoneNumber = ViewModel.NewContact.PhoneNumber });
                ViewModel.NewContact = new Contact();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel.SelectedContact != null)
            {
                ViewModel.Contacts.Remove(ViewModel.SelectedContact);
                ViewModel.SelectedContact = null;
            }
        }
    }
}
