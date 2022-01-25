using DataBindingExamples.ViewModels;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace DataBindingExamples.Views
{
    public partial class NonTrivialBinding4 : ContentPage
    {
        ItemD item;

        public NonTrivialBinding4()
        {
            InitializeComponent();
            item = new ItemD();

            this.BindingContext = item;
        }

        public async void ButtonClicked(object sender, EventArgs args)
        {
            await DisplayAlert("Values of Item", $"Message: {item.Message}\nCreation: {item.Creation:F}", "OK");
        }
    }
}

