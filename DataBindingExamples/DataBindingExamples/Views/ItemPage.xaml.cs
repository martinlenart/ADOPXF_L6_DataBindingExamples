using DataBindingExamples.ViewModels;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace DataBindingExamples.Views
{
    public partial class ItemPage : ContentPage
    {
        ItemViewModel item;

        public ItemPage()
        {
            InitializeComponent();
            item = new ItemViewModel { Title = "First", Description = "1st item" };

            this.BindingContext = item;
        }

        public async void ButtonClicked(object sender, EventArgs args)
        {
            await DisplayAlert("Item Object", "Title property:" + item.Title.ToString(), "OK");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            item.Title = "Updated Value";
            item.Description = "Updated Description";
        }
    }

    public class ItemA
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    #region INotifyPropertyChange
    public class ItemB : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string _title;

        public string Title
        {
            set
            {
                if (value != _title)
                {
                    _title = value;
                    OnPropertyChanged("Title");
                }
            }
            get => _title;
        }

        string _description;

        public string Description
        {
            set
            {
                if (value != _description)
                {
                    _description = value;
                    OnPropertyChanged("Description");
                }
            }
            get => _description;
        }


        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    #endregion


}

