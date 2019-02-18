using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using indexmyphotos.Base;
using indexmyphotos.Controls.ViewModel;
using indexmyphotos.Converter;
using indexmyphotos.IOLogic.Importer;

namespace indexmyphotos.Tabs.ViewModel
{
    public class MainTabControlVM : BaseVM
    {
        private ObservableCollection<ImageControlVM> _items;
        public ObservableCollection<ImageControlVM> Items
        {
            get { return _items; }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    OnPropertyChanged();
                }
            }
        }

        public MainTabControlVM() : base()
        {
        }
    }
}
