using indexmyphotos.Controls.ViewModel;
using indexmyphotos.Tabs.ViewModel;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace indexmyphotos.Base
{
    public class BaseVM : INotifyPropertyChanged
    {
        public static MainTabControlVM mainTabVM;

        public ObservableCollection<ImageControlVM> Items { get { return mainTabVM.Items; } }

        private string _searchText;


        public string SearchText
        {
            get { return string.IsNullOrEmpty(_searchText) ? "" : _searchText; }
            set
            {
                if (_searchText != value)
                {
                    _searchText = value;
                    OnPropertyChanged();
                    ApplyFilter(value);
                }
            }
        }

        private bool mutex = false;

        void ApplyFilter(string query)
        {
            if (mutex)
            {

            }

            mutex = true;

            if (string.IsNullOrEmpty(query))
            {
                foreach (ImageControlVM vm in Items)
                {
                    vm.Visibility = Visibility.Visible;
                }
            }
            else
            {
                foreach (ImageControlVM vm in Items)
                {
                    Visibility v = Visibility.Collapsed;
                    foreach (string s in vm.Tags)
                    {
                        if (s.Contains(query))
                            v = Visibility.Visible;
                    }

                    vm.Visibility = v;
                }
            }
            
            mutex = false;
            OnPropertyChanged("VisibleItemCount");
        }


        public int VisibleItemCount
        {
            get { return Items.Where(i => i.Visibility == Visibility.Visible).Count(); }
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
