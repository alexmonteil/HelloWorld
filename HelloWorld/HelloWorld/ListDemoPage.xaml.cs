using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using HelloWorld.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListDemoPage : ContentPage
    {

        private ObservableCollection<Contact> _contacts;
        public ListDemoPage()
        {
            InitializeComponent();

            _contacts = new ObservableCollection<Contact>
            {
                new Contact() { Name = "Mosh", ImageUrl = "https://picsum.photos/id/65/1920/1200.jpg", Status = "Hey How's it going?"},
                new Contact() { Name = "John", ImageUrl = "https://picsum.photos/id/62/1920/1200.jpg", Status = "Hi, Let's talk!"}
            };
            listView.ItemsSource = _contacts;
        }

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact?.Name, "OK");
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            DisplayAlert("Selected", contact?.Name, "OK");
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            DisplayAlert("Call", contact.Name, "OK");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }

        private void ListView_OnRefreshing(object sender, EventArgs e)
        {

            // would make a call to a web service
            // set listView.ItemSource to the updated list
            // call listView.EndRefresh(); 
            throw new NotImplementedException();
        }

        private void InputView_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(e.NewTextValue))
            {
                listView.ItemsSource = _contacts;
                
            }
            else
            {
                listView.ItemsSource = _contacts.Where(c => c.Name.StartsWith(e.NewTextValue));
            }

        }
    }
}