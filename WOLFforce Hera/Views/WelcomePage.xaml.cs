using Microsoft.UI.Xaml.Controls;

using WOLFforce_Hera.ViewModels;

namespace WOLFforce_Hera.Views;

public sealed partial class WelcomePage : Page
{
    public WelcomeViewModel ViewModel
    {
        get;
    }

    public WelcomePage()
    {
        ViewModel = App.GetService<WelcomeViewModel>();
        InitializeComponent();
    }
}
