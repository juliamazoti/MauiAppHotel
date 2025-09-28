using Microsoft.Extensions.Logging;

namespace MauiAppHotel
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
                    fonts.AddFont("Montserrat-Black.ttf", "MontserratBlack");
                    fonts.AddFont("Montserrat-Bold.ttf", "MontserratBold");
                    fonts.AddFont("Montserrat-Italic.ttf", "MontserratItalic");
                    fonts.AddFont("Montserrat-Medium.ttf", "MontserratMedium");
                    fonts.AddFont("Montserrat-Light.ttf", "MontserratLight");
                    fonts.AddFont("Montserrat-Thin.ttf", "MontserratThin");
                    fonts.AddFont("Montserrat-Regular.ttf", "MontserratRegular");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
