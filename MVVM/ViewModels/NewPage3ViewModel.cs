using CommunityToolkit.Mvvm.ComponentModel;
using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModels
{
    [QueryProperty(nameof(Person),"PersonKey")]
    public partial class NewPage3ViewModel : ObservableObject
    {
        [ObservableProperty]
        Person person;
    }
}
