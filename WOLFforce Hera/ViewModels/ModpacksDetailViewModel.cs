using CommunityToolkit.Mvvm.ComponentModel;

using WOLFforce_Hera.Contracts.ViewModels;
using WOLFforce_Hera.Core.Contracts.Services;
using WOLFforce_Hera.Core.Models;

namespace WOLFforce_Hera.ViewModels;

public class ModpacksDetailViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;
    private SampleOrder? _item;

    public SampleOrder? Item
    {
        get => _item;
        set => SetProperty(ref _item, value);
    }

    public ModpacksDetailViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        if (parameter is long orderID)
        {
            var data = await _sampleDataService.GetContentGridDataAsync();
            Item = data.First(i => i.OrderID == orderID);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
