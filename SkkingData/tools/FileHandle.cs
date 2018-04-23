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
              FileStream fs1 = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs1);
            sw.WriteLine(jsonString);
            sw.Flush();
            sw.Close();
            fs1.Close();
        }
        public static void copyFile(String originalPath, String targetPath) {
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

            String dir = Path.GetDirectoryName(path);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            StringBuilder sb = new StringBuilder();

            try
            {
                string print = "";
                using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
                {
                    while ((print = sr.ReadLine()) != null)
                    {
                        sb.Append(print + "\r\n");
                    }
                }
                string str = sb.ToString();
                return str;
            }
            catch {
            }
            return null;
        }
    }
}
