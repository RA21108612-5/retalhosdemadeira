﻿using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Hosting;
using CommunityToolkit.Maui.Maps;
using Microsoft.Maui.Foldable;

namespace retalhosdemadeira
{
    public static partial class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                   .UseFoldable()
#if !WINDOWS
                   .UseMauiMaps()
#endif
                   .UseMauiCommunityToolkitMaps("<BING_MAPS_API_KEY_HERE>") // To generate a Bing Maps API Key, visit https://www.bingmapsportal.com/
                   .UseMauiCommunityToolkit()
                   .UseMauiCommunityToolkitMarkup()
                   .UseMauiCommunityToolkitCamera()
                   .UseMauiCommunityToolkitMediaElement()
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                       fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
                   });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
