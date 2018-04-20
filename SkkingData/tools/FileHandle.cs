using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SkkingData.tools
{
    public class FileHandle
    {
        public void saveFile(String path) {

        }
        public void copyFile(String originalPath, String targetPath) {
            String dir = Path.GetDirectoryName(targetPath);
            if (!Directory.Exists(dir)) {
                Directory.CreateDirectory(dir);
            }
            FileInfo file = new FileInfo(originalPath);
            if (file.Exists)
            {
                file.CopyTo(targetPath, true);
            }
        }

        public String readFile(String path) {

            return null;
        }
    }
}
