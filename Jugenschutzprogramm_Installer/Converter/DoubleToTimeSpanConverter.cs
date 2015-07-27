﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace Jugenschutzprogramm_Installer.Converter
{
    class DoubleToTimeSpanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((TimeSpan) value).TotalHours;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return TimeSpan.FromMinutes((double) value * 60);
        }
    }
}