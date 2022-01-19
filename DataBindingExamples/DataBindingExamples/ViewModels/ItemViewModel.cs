using System;
using System.Collections.Generic;
using System.Text;

namespace DataBindingExamples.ViewModels
{
    #region INotifyPropertyChange with BaseViewModel
    internal class ItemViewModel : BaseViewModel
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
    #endregion
}
