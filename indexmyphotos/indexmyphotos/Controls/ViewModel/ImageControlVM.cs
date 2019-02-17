using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indexmyphotos.Base;

namespace indexmyphotos.Controls.ViewModel
{
    public class ImageControlVM : BaseVM
    {

        private string _imagePath;
        public string ImagePath
        {
            get { return _imagePath; }
            set
            {
                if (_imagePath != value)
                {
                    _imagePath = value;
                    OnPropertyChanged();
                }
            }
        }

        public ImageControlVM(string path) : base()
        {
            this.ImagePath = path;
        }

    }
}
