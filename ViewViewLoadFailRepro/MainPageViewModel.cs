using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ViewViewLoadFailRepro
{
    public partial class MainPageViewModel: ObservableObject
    {
        public MainPageViewModel()
        {
            GpxStudioUrl = BuildUrl();
        }

        [ObservableProperty]
        public string gpxStudioUrl;

        [RelayCommand]
        public async Task OpenExternal()
        {
            await Browser.Default.OpenAsync(GpxStudioUrl);
        }

        private string BuildUrl()
        {
            return "https://gpx.studio/?state=%7b%22urls%22%3a%5b%22https%3a%2f%2fat1.samorokov.online%2fapi%2fGpxFile%3ftrackId%3d3f709779-0be0-4863-bdd7-08d1674f6ccd%22%5d%7d&distance&direction&slope&imperial";
        }
    }
}
