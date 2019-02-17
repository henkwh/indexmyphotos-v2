using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indexmyphotos.Base;

namespace indexmyphotos.Windows.ViewModel
{
    public class MainWindowVM : BaseVM
    {
        #region properties

        private string _searchText;

        public string SearchText
        {
            get { return _searchText; }
            set
            {
                if (_searchText != value)
                {
                    _searchText = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        public MainWindowVM()
        {
            SearchText = "";
        }

    }
}
