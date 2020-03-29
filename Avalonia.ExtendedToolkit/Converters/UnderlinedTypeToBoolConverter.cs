﻿using System;
using System.Globalization;
using Avalonia.Controls;
using Avalonia.Data.Converters;
using Avalonia.ExtendedToolkit.Controls;

namespace Avalonia.ExtendedToolkit.Converters
{
    public class UnderlinedTypeToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            IControl control = value as IControl;
            if (control != null && parameter is UnderlinedType)
            {
                UnderlinedType underlinedTypeParam = (UnderlinedType)parameter;

                UnderlinedType underlinedType = TabControlHelper.GetUnderlined(control);
                if (underlinedType == underlinedTypeParam)
                    return true;
            }

            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return AvaloniaProperty.UnsetValue;
        }
    }
}
