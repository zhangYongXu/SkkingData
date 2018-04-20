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
        public static void saveJsonFile(String path,String jsonString) {
               FileStream fs1 = new FileStream(path, FileMode.Create, FileAccess.Write);
           
               fs1.Close();
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

        public static String readJsonFile(String path) {
            if (null == path) {
                return null;
            }
            try
            {
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line.ToString());
                }
                sr.Close();
                return line;
            }
            catch {

            }
            
            return null;
        }
    }
}
