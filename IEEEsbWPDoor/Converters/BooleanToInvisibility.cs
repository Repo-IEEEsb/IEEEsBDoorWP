﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace IEEEsbWPDoor.Converters
{
    public class BooleanToInvisibility:IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if ((bool)value) return Visibility.Collapsed;
            else return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
