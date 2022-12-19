using Microsoft.UI.Xaml.Controls;

using WOLFforce_Hera.ViewModels;

namespace WOLFforce_Hera.Views;

public sealed partial class ShadersPage : Page
{
    public ShadersViewModel ViewModel
    {
        get;
    }

    public ShadersPage()
    {
        ViewModel = App.GetService<ShadersViewModel>();
        InitializeComponent();
    }
}
