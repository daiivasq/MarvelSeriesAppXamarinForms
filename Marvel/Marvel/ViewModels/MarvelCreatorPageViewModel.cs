using Marvel.Models;
using Marvel.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using static Marvel.Models.Series ;

namespace Marvel.ViewModels
{
    public class MarvelCreatorPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Result> ListSeries { get; set; }

        IApiServices _apiService = new ApiService();

        ApiService apiServiceRefit = new ApiService();

        public MarvelCreatorPageViewModel()
        {
            SeriesInformationRefit();

            SeriesInformationHttp();
        }


        async Task SeriesInformationRefit()
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                try
                {
                    var info = await apiServiceRefit.CallApi();

                    ListSeries = new ObservableCollection<Result>(info.DataProp.Results);

                }
                catch (Exception Api)
                {
                    Debug.WriteLine($"Api Exception{Api}");
                    throw;
                }
            }

        }
        async Task SeriesInformationHttp()
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                try
                {
                    var info = await _apiService.GetInformationAsync();

                    ListSeries = new ObservableCollection<Result>(info.DataProp.Results);

                }
                catch (Exception Api)
                {
                    Debug.WriteLine($"Api Exception{Api}");
                    throw;
                }
            }
      
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
