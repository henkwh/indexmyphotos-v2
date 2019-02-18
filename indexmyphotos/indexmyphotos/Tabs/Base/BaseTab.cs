using System.Collections.ObjectModel;
using System.Windows.Controls;
using indexmyphotos.Controls.ViewModel;

namespace indexmyphotos.Tabs.Base
{
    public class BaseTab : UserControl
    {
        protected ObservableCollection<ImageControlVM> imageControls;
    }
}
