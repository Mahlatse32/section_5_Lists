using Lists.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lists
{
    public partial class MainPage : ContentPage
    {

        #region selection and tabbed event

        //private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var contact = e.SelectedItem as Contact;

        //    DisplayAlert("Item selected", contact.Name, "Ok");
        //}

        //private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    var contact = e.Item as Contact;

        //    DisplayAlert("Item tapped", contact.Name, "Ok");
        //}

        #endregion

        #region Context Actions
        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "ok");
        }

        private ObservableCollection<Contact> _contacts;
        private void Delete_Clicked_1(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }
        #endregion

        public MainPage()
        {
            InitializeComponent();

            #region for the contact display
            //var names = new List<Contact>
            //{
            //    new Contact{ Name = "Mahlatse", ImageUrl = "http://lorempixel.com/100/100/people/1", Status = "Available"},
            //    new Contact{ Name = "Mpho", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "hahaha. . ."},
            //    new Contact{ Name = "Emma", ImageUrl = "http://lorempixel.com/100/100/people/3"}
            //};

            //listView.ItemsSource = names;
            #endregion

            #region Group Contact

            //newListView.ItemsSource = new List<GroupContact>
            //{
            //        new GroupContact("M", "M")
            //        {
            //            new Contact{ Name = "Mahlatse", ImageUrl = "http://lorempixel.com/100/100/people/1", Status = "Available"}
            //        },

            //        new GroupContact("E", "E")
            //        {
            //            new Contact{ Name = "Emma", ImageUrl = "http://lorempixel.com/100/100/people/3"}
            //        } 
            //};

            #endregion

            #region selection and tabbed event

            //var contacts = new List<Contact>
            //{
            //    new Contact{ Name = "Mahlatse", Status = "yeah man"},
            //    new Contact{ Name = "Emma", Status = "There you are"}
            //};

            //listView.ItemsSource = contacts;

            #endregion

            #region Context Actions

            _contacts = new ObservableCollection<Contact>
            {
                new Contact{ Name = "Mahlatse", ImageUrl = "http://lorempixel.com/100/100/people/1", Status = "Available"},
                new Contact{ Name = "Mpho", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "hahaha. . ."},
                new Contact{ Name = "Emma", ImageUrl = "http://lorempixel.com/100/100/people/3"}
            };

            listView.ItemsSource = _contacts;
            #endregion
        }
        #region placeholder
        #endregion

    }
}
