using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using indexmyphotos.Controls.ViewModel;

namespace indexmyphotos.Converter
{
    public class SubstringToListConverter
    {
        public void Convert(string query, ObservableCollection<ImageControlVM> list)
        {
            /*if (string.IsNullOrEmpty(query))
            {
                list.ToList().ForEach(i => i.Visibility = Visibility.Visible);
                return;
            }

            foreach (ImageControlVM control in list)
            {
                control.Visibility = Visibility.Collapsed;
                foreach (string tag in control.Tags)
                {
                    if (tag.Contains(query))
                    {
                        control.Visibility = Visibility.Visible;
                    }
                }
            }*/


        }
    }
}
