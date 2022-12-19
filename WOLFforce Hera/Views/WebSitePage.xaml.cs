using Microsoft.UI.Xaml.Controls;

using WOLFforce_Hera.ViewModels;

namespace WOLFforce_Hera.Views;

// To learn more about WebView2, see https://docs.microsoft.com/microsoft-edge/webview2/.
public sealed partial class WebSitePage : Page
{
    public WebSiteViewModel ViewModel
    {
        get;
    }

    public WebSitePage()
    {
        ViewModel = App.GetService<WebSiteViewModel>();
        InitializeComponent();

        ViewModel.WebViewService.Initialize(WebView);
    }
}
