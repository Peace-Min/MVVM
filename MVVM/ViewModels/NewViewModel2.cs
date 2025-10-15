using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
            Shell.Current.GoToAsync(nameof(NewPage1));
        }
    }
}
