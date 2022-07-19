using Gutties.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Gutties.Views
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