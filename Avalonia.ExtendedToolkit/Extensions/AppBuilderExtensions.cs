﻿
using Avalonia.ExtendedToolkit.Controls;
using Avalonia.ExtendedToolkit;
using Splat;

namespace Avalonia.ExtendedToolkit.Extensions
{
    /// <summary>
    /// class for application extensions
    /// </summary>
    public static class AppBuilderExtensions
    {
        /// <summary>
        /// registers some extra service
        /// </summary>
        //.orig
        //public static TAppBuilder UseAvaloniaExtended<TAppBuilder>(this TAppBuilder builder)
        //    where TAppBuilder : AppBuilderBase<TAppBuilder>, new()
        //{
        //    var result = builder.AfterPlatformServicesSetup(x =>
        //    {
        //        if (Locator.CurrentMutable is null)
        //        {
        //            return;
        //        }
        //        Locator.CurrentMutable.Register<IFileDialogService>(() => new FileDialogService());
        //    });

        //    return result;
        //}
    }
}
