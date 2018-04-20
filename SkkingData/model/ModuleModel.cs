using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkkingData.model;
using System.IO;
using System.Collections;
using SkkingData.tools;
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
        public LType type;
        public String commonPath;
        public String jsonFileLocalPath;


        public void initData() {
            
            String cPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\滑雪数据\\jsonData\\";
            switch (type)
            {

                case LType.LTypeErTongShuangBan:
                    {
                        commonPath = cPath + "er_tong_shuang_ban_jiao_cheng\\";
                        jsonFileLocalPath = commonPath + "lesson_json_er_tong_shuang_ban.txt";
                    }
                    break;
                case LType.LTypeChengRenShuangBan:
                    {
                        commonPath = cPath + "cheng_ren_shuang_ban_jiao_cheng\\";
                        jsonFileLocalPath = commonPath + "lesson_json_cheng_ren_shuang_ban.txt";
                    }
                    break;
                case LType.LTypeErtongDanBan:
                    {
                        commonPath = cPath + "er_tong_dan_ban_jiao_cheng\\";
                        jsonFileLocalPath = commonPath + "lesson_json_er_tong_dan_ban.txt";
                    }
                    break;
                case LType.LTypeChengRenDanBan:
                    {
                        commonPath = cPath + "cheng_ren_dan_ban_jiao_cheng\\";
                        jsonFileLocalPath = commonPath + "lesson_json_cheng_ren_dan_ban.txt";
                    }
                    break;
            }


            String filePath = jsonFileLocalPath;
            String jsonString = FileHandle.readJsonFile(filePath);

            List<LessonModel> lList = (List<LessonModel>)JSONHandle.getObjFromJson<List<LessonModel>>(jsonString);

            if (lList == null) {
                return;
            }
            foreach (LessonModel m in lList) {
                lessonList.Add(m);
            }
        }

    }
}
