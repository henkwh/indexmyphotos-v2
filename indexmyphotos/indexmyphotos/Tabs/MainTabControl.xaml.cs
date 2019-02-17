using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using indexmyphotos.Tabs.Base;

namespace indexmyphotos.Tabs
{
    /// <summary>
    /// Interaktionslogik für MainTabControl.xaml
    /// </summary>
    public partial class MainTabControl : BaseTab
    {
        public MainTabControl()
        {
            InitializeComponent();

            DataContext = new MainTabControlVM()
            {

            };
        }
    }
}
