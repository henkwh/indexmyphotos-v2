using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using indexmyphotos.Base;
using indexmyphotos.Controls.ViewModel;
using indexmyphotos.IOLogic.Importer;
using indexmyphotos.Tabs.Base;
using indexmyphotos.Tabs.ViewModel;

namespace indexmyphotos.Windows.ViewModel
{
    public class MainWindowVM : BaseVM
    {
        #region properties

        public MainTabControlVM MainTabControlVM { get; set; }

        #endregion

        public MainWindowVM() : base()
        {
            MainTabControlVM = mainTabVM = new MainTabControlVM();

            MainTabControlVM.Items = new ObservableCollection<ImageControlVM>();

            ImageImporter i = new ImageImporter();

            foreach (string s in i.GetFiles())
            {
                MainTabControlVM.Items.Add(new ImageControlVM(s));
            }
        }

    }
}
