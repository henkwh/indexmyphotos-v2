using indexmyphotos.Windows.ViewModel;
using System.Windows;

namespace indexmyphotos.Windows
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowVM()
            {

            };
        }
    }
}
