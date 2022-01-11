using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

namespace DataBindingExamples.ViewModels
{
    public class TitleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        String title;
        
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


        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
