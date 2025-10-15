using Microsoft.Extensions.Logging;
using MVVM.ViewModels;
using MVVM.Views;

namespace MVVM
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.AddSingleton<NewViewModel>();
            builder.Services.AddSingleton<NewViewModel2>();
            builder.Services.AddSingleton<NewPage1>();
            builder.Services.AddSingleton<NewPage2>();
            builder.Services.AddSingleton<NewPage2ViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
