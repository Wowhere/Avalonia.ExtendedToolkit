using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Avalonia.Media;

namespace Avalonia.ExtendedToolkit.Extensions
{
    /// <summary>
    /// fontfamily extension class
    /// </summary>
    public static class FontFamilyExtensions
    {
        private static List<FontFamily> _fontFamilies = new List<FontFamily>();
        
        /// <summary>
        /// returns the current installed fonts
        /// </summary>
        public static IEnumerable<FontFamily> InstalledFontFamilies
        {
            get
            {
                if (_fontFamilies.Count == 0)
                {
                    //.orig
                    //to think later, Implementing a custom IFontManagerImpl was previously suggested as a solution, but this approach may no longer work due to changes in accessibility levels.
                    //foreach (var item in FontManager.Current.GetInstalledFontFamilyNames())
                    //{
                    //    _fontFamilies.Add(new FontFamily(item));
                    //}
                }
                return FontManager.Current.SystemFonts;
            }
        }


    }
}
