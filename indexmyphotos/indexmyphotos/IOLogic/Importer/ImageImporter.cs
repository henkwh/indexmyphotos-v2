using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace indexmyphotos.IOLogic.Importer
{
    public class ImageImporter
    {
        private List<string> paths = new List<string>();


        public ImageImporter()
        {
            paths = new List<string>();


            string mainpath = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location),
                @"..\..\"));

            paths.Add(mainpath + "SampleImages");
        }

        public List<string> GetFiles()
        {
            List<string> retValue = new List<string>();
            foreach (string path in paths)
            {
                foreach (string file in Directory.EnumerateFiles(path, "*.jpg"))
                {
                    for (int i = 0; i < 500; i++)
                        retValue.Add(file);
                }
            }
 
            return retValue;
        }


    }
}
