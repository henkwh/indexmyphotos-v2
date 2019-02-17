using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using indexmyphotos.Controls.ViewModel;
using indexmyphotos.Tabs;
using indexmyphotos.Tabs.Base;

namespace indexmyphotos.Base
{
    public class BaseVM : INotifyPropertyChanged
    {

        //private bool isMainViewModel;

        private static string _searchText;

        public static event EventHandler SearchTextChanged;

        public static string SearchText
        {
            get { return string.IsNullOrEmpty(_searchText) ? "" : _searchText; }
            set
            {
                if (_searchText != value)
                {
                    _searchText = value;
                    SearchTextChanged(null, EventArgs.Empty);
                }
            }
        }

        public BaseVM()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
