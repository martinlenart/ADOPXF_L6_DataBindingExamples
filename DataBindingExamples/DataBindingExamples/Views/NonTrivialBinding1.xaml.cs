﻿using DataBindingExamples.ViewModels;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace DataBindingExamples.Views
{
    public partial class NonTrivialBinding1 : ContentPage
    {
        ItemA item;
        Random rnd;

        public NonTrivialBinding1()
        {
            InitializeComponent();
            item = new ItemA { Message = "A message from item", Creation = DateTime.Now};
            rnd = new Random();

            this.BindingContext = item;
        }

        public async void ButtonClicked(object sender, EventArgs args)
        {
            await DisplayAlert("Values of Item", $"Message: {item.Message}\nCreation: {item.Creation:F}", "OK");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            item.Message = $"A message set in C# code with a random number: {rnd.Next(1000)}";
            item.Creation = item.Creation + new TimeSpan(10, 10, 10, 0); // add 10 days, 10 hours, 10 minutes 
        }
    }

    public class ItemA
    {
        public string Message { get; set; }
        public DateTime Creation { get; set; }
    }
}

