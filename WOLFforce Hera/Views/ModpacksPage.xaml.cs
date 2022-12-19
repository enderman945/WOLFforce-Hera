using Microsoft.UI.Xaml.Controls;

using WOLFforce_Hera.ViewModels;

namespace WOLFforce_Hera.Views;

public sealed partial class ModpacksPage : Page
{
    public ModpacksViewModel ViewModel
    {
        get;
    }

    public ModpacksPage()
    {
        ViewModel = App.GetService<ModpacksViewModel>();
        InitializeComponent();
    }
}
