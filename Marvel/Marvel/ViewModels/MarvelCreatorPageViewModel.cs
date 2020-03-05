using Marvel.Models;
using Marvel.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using static Marvel.Models.Series ;

namespace Marvel.ViewModels
{
    public class MarvelCreatorPageViewModel : INotifyPropertyChanged
    {
        
        public ObservableCollection<Result> ListMovies { get; set; }

        public ICommand Validate { get; set; }

        IApiServices _apiService = new ApiService();

        public MarvelCreatorPageViewModel()
        {
            CreatorsInformation();
            
        }

        async void CreatorsInformation()
        {
        var lol =  await _apiService.GetCreatorsInformationAsync();

            ListMovies = new ObservableCollection<Result>(lol.DataProp.Results);

        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
