using MVVM.ViewModels;

namespace MVVM.Views;

public partial class NewPage3 : ContentPage
{
    public NewPage3(NewPage3ViewModel newPage3ViewModel)
    {
        InitializeComponent();
        BindingContext = newPage3ViewModel;
    }
}