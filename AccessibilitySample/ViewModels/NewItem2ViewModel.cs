using System;
using AccessibilitySample.Models;
using Xamarin.Forms;

namespace AccessibilitySample.ViewModels
{
    public class NewItem2ViewModel : BaseViewModel
    {
        private string text;
        private string description;
        private Color backgroundColor;
        private Color textColor;
        private string colorContrast;


        public NewItem2ViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(text)
                && !String.IsNullOrWhiteSpace(description);
        }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public Color BackgroundColor
        {
            get => backgroundColor;
            set => SetProperty(ref backgroundColor, value);
        }

        public Color TextColor
        {
            get => textColor;
            set => SetProperty(ref textColor, value);
        }

        public string ColorContrast
        {
            get => colorContrast;
            set => SetProperty(ref colorContrast, value);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            Item newItem = new Item()
            {
                Id = Guid.NewGuid().ToString(),
                Text = Text,
                Description = Description,
                BackgroundColor = BackgroundColor,
                TextColor = TextColor,
                Contrast = ColorContrast
            };

            await DataStore.AddItemAsync(newItem);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
