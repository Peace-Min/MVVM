using MVVM.ViewModels;

namespace MVVM.Views;

public partial class NewPage1 : ContentPage
{
	public NewPage1(NewViewModel2 newViewModel)
	{
		InitializeComponent();
		BindingContext = newViewModel;
	}
}