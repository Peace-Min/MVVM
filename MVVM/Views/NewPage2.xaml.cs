using MVVM.ViewModels;

namespace MVVM.Views;

public partial class NewPage2 : ContentPage
{
	public NewPage2(NewPage2ViewModel newPage2ViewModel)
	{
		InitializeComponent();
		BindingContext = newPage2ViewModel;
	}
}