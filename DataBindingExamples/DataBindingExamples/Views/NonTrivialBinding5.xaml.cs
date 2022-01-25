
using DataBindingExamples.ViewModels;
using Xamarin.Forms;

namespace DataBindingExamples.Views
{
    public partial class NonTrivialBinding5 : ContentPage
    {
        Item[] _items;
        public Item[] Items => _items;

        public NonTrivialBinding5()
        {
            InitializeComponent();

            _items = new Item[] {
                new Item {Title = "First", Description="1st item"},
                new Item {Title = "Second", Description="2nd item"},
                new Item {Title = "Third", Description="3rd item"}
            };

            this.BindingContext = this;
        }

        public async void ListItemTapped(object sender, ItemTappedEventArgs e)
        {
            Item item = (Item)e.Item;
            await DisplayAlert("Tapped", item.Title.ToString() + " was selected.", "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}

