﻿using DataBindingExamples.ViewModels;
using System;
using Xamarin.Forms;

namespace DataBindingExamples.Views
{
    public partial class ListPageUsingListViewModel : ContentPage
    {
        ListViewModel items;

        public ListPageUsingListViewModel()
        {
            InitializeComponent();

            items = new ListViewModel();
            this.BindingContext = items.Items;
        }

        public async void EditClicked(object sender, EventArgs e)
        {
            items.Items[0].Title = "First Edited";
            await DisplayAlert("Item Object", "First row edited", "OK");
        }

        public async void DeleteClicked(object sender, EventArgs e)
        {
            items.Items.RemoveAt(0);
            await DisplayAlert("Delete", "Row deleted", "OK");
        }

        public async void ReplaceClicked(object sender, EventArgs e)
        {
            items.Replace();
            await DisplayAlert("Replace", "List replaced con Español", "OK");
            this.BindingContext = items.Items;
        }

        public async void ListItemTapped(object sender, ItemTappedEventArgs e)
        {
            ObservableItem item = (ObservableItem)e.Item;
            int index = items.Items.IndexOf(item);
            await DisplayAlert("Tapped", $"{item.Title} was selected, item nr = {index + 1}.", "OK");
            ((ListView)sender).SelectedItem = null;
        }

    }
}

