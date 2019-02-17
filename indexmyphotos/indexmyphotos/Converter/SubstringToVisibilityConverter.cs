using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace indexmyphotos.Converter
{
    public class SubstringToVisibilityConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null || values.Length != 2)
                return Visibility.Collapsed;

            string searchText = values[0] as string;

            if (string.IsNullOrEmpty(searchText))
                return Visibility.Visible;

            ObservableCollection<string> tags = values[1] as ObservableCollection<string>;

            if (tags != null)
            {
                foreach (string tag in tags)
                {
                    if (tag.Contains(searchText))
                        return Visibility.Visible;
                }
            }


            return Visibility.Collapsed;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
