using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Windows.Input;

// Chapter 6 — Making a Scrollable List examples from
// Building Xamarin Mobile Apps Using XAML
// a book by Dan Hermes and Dr. Nima Mazloumi
// published by Apress and available on Amazon

// Read more about Dan Hermes at https://lexicon.systems/aboutdanhermes/
// If you need Xamarin development or consulting visit https://lexicon.systems

namespace DataBindingExamples.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }    
        protected async void navigateToPage(object sender, EventArgs args)
        {
            Type pageType = ((TextCell)sender).CommandParameter as Type;
            Page page = (Page)Activator.CreateInstance(pageType);
            await this.Navigation.PushAsync(page);
        }
    }
}

