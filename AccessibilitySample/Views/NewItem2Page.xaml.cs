using System;
using AccessibilitySample.ViewModels;
using Xamarin.Forms;

namespace AccessibilitySample.Views
{
    public partial class NewItem2Page : ContentPage
    {
        public NewItem2Page()
        {
            InitializeComponent();
            BindingContext = new NewItem2ViewModel();

            SetAccessibilityValues();
        }

        // TODO: Instead of using hardcoded text for accessibility items, use a RESX file (same as you would for multiple languages)

        private void SetAccessibilityValues()
        {
            AutomationProperties.SetIsInAccessibleTree(textLabel, false);
            AutomationProperties.SetName(textLabel, "Text Label");

            AutomationProperties.SetIsInAccessibleTree(textEntry, true);
            AutomationProperties.SetLabeledBy(textEntry, textLabel);

            // Redundant / Excess verbiage
            AutomationProperties.SetHelpText(textEntry, "My Text Entry");

            AutomationProperties.SetIsInAccessibleTree(descriptionLabel, false);

            AutomationProperties.SetIsInAccessibleTree(descriptionEditor, true);
            AutomationProperties.SetLabeledBy(descriptionEditor, descriptionLabel);

            // Redundant / Excess verbiage
            AutomationProperties.SetHelpText(descriptionEditor, "My Description Editor");

            AutomationProperties.SetIsInAccessibleTree(cancelButton, true);
            AutomationProperties.SetName(cancelButton, "Cancel");

            AutomationProperties.SetIsInAccessibleTree(saveButton, true);
            AutomationProperties.SetName(saveButton, "Save");

            if (Device.RuntimePlatform == Device.iOS)
            {
                AutomationProperties.SetHelpText(cancelButton, "Activate to cancel add new item.");
                AutomationProperties.SetHelpText(saveButton, "Activate to save new item.");
            }

            // TODO:  Can also use data binding to set these values. set to values and remember to RaiseProperty changed when needed.
            //cancelButton.SetBinding(AutomationProperties.NameProperty, nameof(NewItem2ViewModel.CancelAutomationName));
            //cancelButton.SetBinding(AutomationProperties.HelpTextProperty, nameof(NewItem2ViewModel.CancelAutomationHelptext));
            //cancelButton.SetBinding(AutomationProperties.IsInAccessibleTreeProperty, nameof(NewItem2ViewModel.CancelIsInTree));
        }
    }
}
