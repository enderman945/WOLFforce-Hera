using Microsoft.UI.Xaml.Controls;

using WOLFforce_Hera.ViewModels;

namespace WOLFforce_Hera.Views;

public sealed partial class ResourcePacksPage : Page
{
    public ResourcePacksViewModel ViewModel
    {
        get;
    }

    public ResourcePacksPage()
    {
        ViewModel = App.GetService<ResourcePacksViewModel>();
        InitializeComponent();
    }
}
