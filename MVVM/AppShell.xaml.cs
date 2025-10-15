using MVVM.Views;

namespace MVVM
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(NewPage2), typeof(NewPage2));
            Routing.RegisterRoute(nameof(NewPage3), typeof(NewPage3));
        }
    }
}
