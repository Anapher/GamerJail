﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace Jugenschutzprogramm_Installer.Converter
{
    class MultiplyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((double)value) * double.Parse(parameter.ToString(), CultureInfo.InvariantCulture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
