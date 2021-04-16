using AccessibilitySample.ViewModels;
using Xamarin.Forms;

namespace AccessibilitySample.Views
{
    public partial class ColorContrastPage : ContentPage
    {
        ColorContrastViewModel _viewModel;

        public ColorContrastPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ColorContrastViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}
