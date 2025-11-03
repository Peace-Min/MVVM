using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Encyc.Models;
using Encyc.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encyc.ViewModels
{
    public partial class EncycViewModel : ObservableObject
    {
        private ApiService _apiService;
        public EncycViewModel(ApiService api)
        {
            this._apiService = api;
        }

        [ObservableProperty]
        string queryText;

        public ObservableCollection<ApiItem> EncycItems { get; set; } = new();

        private async Task GetEncycList()
        {
            var result = await _apiService.GetEncycAsync(QueryText);
            foreach(var item in result.Items)
            {
                EncycItems.Add(item);
            }
        }

        [RelayCommand]
        void 조회하기()
        {
            EncycItems.Clear();
            GetEncycList();
        }
    }
}
