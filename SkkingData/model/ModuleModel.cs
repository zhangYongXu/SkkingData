using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkkingData.model;
using System.IO;
using System.Collections;
namespace SkkingData.model
{
    public class ModuleModel
    {
        public ModuleModel() {
        }
        public ModuleModel(LType type) {
            lessonList = new ArrayList();
            this.type = type;
            initData();
        }

        public ArrayList lessonList;
        //public LinkedList<LessonModel> lessonList ;
        public LType type;
        public String commonPath;

        public void initData() {
            
            String cPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\滑雪数据\\jsonData\\";
            switch (type)
            {

                case LType.LTypeErTongShuangBan:
                    {
                        commonPath = cPath + "er_tong_shuang_ban_jiao_cheng\\";
                    }
                    break;
                case LType.LTypeChengRenShuangBan:
                    {
                        commonPath = cPath + "cheng_ren_dan_ban_jiao_cheng\\";
                    }
                    break;
                case LType.LTypeErtongDanBan:
                    {
                        commonPath = cPath + "er_tong_dan_ban_jiao_cheng\\";
                    }
                    break;
                case LType.LTypeChengRenDanBan:
                    {
                        commonPath = cPath + "cheng_ren_dan_ban_jiao_cheng\\";
                    }
                    break;
            }
        }

    }
}
