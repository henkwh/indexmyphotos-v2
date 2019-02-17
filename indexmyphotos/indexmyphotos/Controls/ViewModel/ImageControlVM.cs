using System.Collections.ObjectModel;
using System.Diagnostics.Eventing.Reader;
using indexmyphotos.Base;
using System.IO;
using System.Windows;

namespace indexmyphotos.Controls.ViewModel
{
    public class ImageControlVM : BaseVM
    {
        #region properties

        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set
            {
                if (_filePath != value)
                {
                    _filePath = value;
                    OnPropertyChanged();
                }
            }
        }

        public string FileName
        {
            get { return Path.GetFileName(FilePath); }
        }

        private ObservableCollection<string> _tags;
        public ObservableCollection<string> Tags
        {
            get { return _tags; }
            set
            {
                if (_tags != value)
                {
                    _tags = value;
                    OnPropertyChanged();
                }
            }
        }

        /*private Visibility _visibility;
        public Visibility Visibility
        {
            get { return _visibility; }
            set
            {
                if (_visibility != value)
                {
                    _visibility = value;
                    OnPropertyChanged();
                }
            }
        }*/

        #endregion

        public ImageControlVM(string path) : base()
        {
            this.Tags = new ObservableCollection<string>();
            this.FilePath = path;

            if (path.Contains("F1-BB-A9-B9-78-F2-68-92-48-FC-56-49-41-33-3B-4C-A9-2E-D4-3B.jpg") || path.Contains("F0-B1-AF-79-E5-5C-29-5A-F4-26-58-D4-3E-0E-17-09-F4-AD-C3-0D.jpg"))
            {
                Tags.Add("test");
            }
        }

    }
}
