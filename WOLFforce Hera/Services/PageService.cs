using CommunityToolkit.Mvvm.ComponentModel;

using Microsoft.UI.Xaml.Controls;

using WOLFforce_Hera.Contracts.Services;
using WOLFforce_Hera.ViewModels;
using WOLFforce_Hera.Views;

namespace WOLFforce_Hera.Services;

public class PageService : IPageService
{
    private readonly Dictionary<string, Type> _pages = new();

    public PageService()
    {
        Configure<WelcomeViewModel, WelcomePage>();
        Configure<ModpacksViewModel, ModpacksPage>();
        Configure<ModpacksDetailViewModel, ModpacksDetailPage>();
        Configure<ShadersViewModel, ShadersPage>();
        Configure<ResourcePacksViewModel, ResourcePacksPage>();
        Configure<WebSiteViewModel, WebSitePage>();
        Configure<SettingsViewModel, SettingsPage>();
    }

    public Type GetPageType(string key)
    {
        Type? pageType;
        lock (_pages)
        {
            if (!_pages.TryGetValue(key, out pageType))
            {
                throw new ArgumentException($"Page not found: {key}. Did you forget to call PageService.Configure?");
            }
        }

        return pageType;
    }

    private void Configure<VM, V>()
        where VM : ObservableObject
        where V : Page
    {
        lock (_pages)
        {
            var key = typeof(VM).FullName!;
            if (_pages.ContainsKey(key))
            {
                throw new ArgumentException($"The key {key} is already configured in PageService");
            }

            var type = typeof(V);
            if (_pages.Any(p => p.Value == type))
            {
                throw new ArgumentException($"This type is already configured with key {_pages.First(p => p.Value == type).Key}");
            }

            _pages.Add(key, type);
        }
    }
}
