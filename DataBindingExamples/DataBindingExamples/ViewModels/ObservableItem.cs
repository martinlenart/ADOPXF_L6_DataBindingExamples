using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

namespace DataBindingExamples.ViewModels
{
    internal class ObservableItem : BaseViewModel
    {
        string title;
        string description;

        public string Title
        {
            set => Set<string>(ref title, value, "Title");
            get => title;
        }
        public string Description
        {
            set => Set<string>(ref description, value, "Description");
            get => description;
        }
    }
}
