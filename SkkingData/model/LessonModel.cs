using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkkingData.model
{
    public enum LType {
        LTypeErTongShuangBan = 1,
        LTypeChengRenShuangBan = 2,
        LTypeErtongDanBan = 3,
        LTypeChengRenDanBan = 4
    };
    
    public class LessonModel
    {
        public int itemId;
        public String name;
        public String description;
        public String imageName;
        public LType type =0;
        public String imagePath;
        public int orderNum;

        public String localCommonDirPath;
        public String videoZhengJueJsonFileName;
        public String videoZhengJueJsonFilePath;
        public String videoCuoWuJsonFileName;
        public String videoCuoWuJsonFilePath;

    }
}
