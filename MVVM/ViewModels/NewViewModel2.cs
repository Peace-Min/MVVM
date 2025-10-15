using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVM.Models;
using MVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModels
{
    public partial class NewViewModel2 : ObservableObject
    {
        [ObservableProperty]
        string text;

        [RelayCommand]
        private void 화면이동(object obj)
        {
            Shell.Current.GoToAsync($"{nameof(NewPage2)}?query={Text}");
        }

        [RelayCommand]
        void 데이터전달하기()
        {
            var persone = new Person()
            {
                Name = "평화",
                Age = 27,
                Address = "신성동",
            };

            Shell.Current.GoToAsync($"{nameof(NewPage3)}", new Dictionary<string, object>()
            {
                {"PersonKey", persone},
            });
        }
    }
}
