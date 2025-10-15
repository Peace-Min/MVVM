using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModels
{
    [QueryProperty(nameof(Text), "query")]
    public partial class NewPage2ViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;
    }
}
