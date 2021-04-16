using System.ComponentModel;
using Xamarin.Forms;
using AccessibilitySample.ViewModels;

namespace AccessibilitySample.Views
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