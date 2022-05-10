using System.ComponentModel;

using AppMaps.ViewModels;

using Xamarin.Forms;

namespace AppMaps.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}