using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataBindingExamples.ViewModels
{
    class ItemBindable : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        string title;
        string description;

        public string Title
        {
            set
            {
                if (!value.Equals(title, StringComparison.Ordinal))
                {
                    title = value;
                    OnPropertyChanged("Title");
                }
            }
            get => title;
        }
        public string Description
        {
            set
            {
                if (!value.Equals(description, StringComparison.Ordinal))
                {
                    description = value;
                    OnPropertyChanged("Description");
                }
            }
            get => description;
        }
    }
}
