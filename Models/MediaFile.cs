using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPBS.Models
{
    public class MediaFile
    {
        public string FilePath { get; set; }
        public string Label { get; set; }

        public MediaFile(string filePath, string label)
        {
            this.FilePath = filePath;
            this.Label = label;
        }
    }
}
