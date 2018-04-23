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
        public LessonModel(LType ltype,int lorderNum)
        {
            type = ltype;
            orderNum = lorderNum;
            initData();
           
        }
        public int itemId;
        public String name;
        public String description;
        public String imageName;
        public LType type =0;
        public String imagePath;
        public int orderNum;

        public String videoLocalCommonDirPath;
        public String jsonLocalCommonDirPath;

        public String videoZhengJueJsonFileName;
        public String videoZhengJueJsonFilePath;

        public String videoCuoWuJsonFileName;
        public String videoCuoWuJsonFilePath;

        public String videoMainJsonFileName;
        public String videoMainJsonFilePath;

        public string getZQVideoDir() {
            return videoLocalCommonDirPath + "正确\\";
        }
        public string getCWVideoDir()
        {
            return videoLocalCommonDirPath + "错误\\";
        }
        public string getMainVideoDir()
        {
            return videoLocalCommonDirPath + "主视频\\";
        }


        private void initData() {
            String cPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\滑雪数据\\视频\\";
            String JPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\滑雪数据\\jsonData\\";


            switch (type)
            {

                case LType.LTypeErTongShuangBan:
                    {
                        videoLocalCommonDirPath = cPath + "儿童双板教程\\第"+(orderNum+1)+"课\\";

                        jsonLocalCommonDirPath = JPath + "er_tong_shuang_ban_jiao_cheng\\videoDetailJson\\" + "item" + (orderNum+1) +"\\";

                        videoZhengJueJsonFileName = "er_tong_shuang_zheng_que_video_json.txt";
                        videoZhengJueJsonFilePath = jsonLocalCommonDirPath + videoZhengJueJsonFileName;

                        videoCuoWuJsonFileName = "er_tong_shuang_zheng_cuo_wu_json.txt";
                        videoCuoWuJsonFilePath = jsonLocalCommonDirPath + videoCuoWuJsonFileName;

                        videoMainJsonFileName = "er_tong_shuang_zheng_main_json.txt";
                        videoMainJsonFilePath = jsonLocalCommonDirPath + videoMainJsonFileName;

                    }
                    break;
                case LType.LTypeChengRenShuangBan:
                    {
                        videoLocalCommonDirPath = cPath + "成人双板教程\\第" + (orderNum + 1) + "课\\";

                        jsonLocalCommonDirPath = JPath + "cheng_ren_shuang_ban_jiao_cheng\\videoDetailJson\\" + "item" + (orderNum + 1) + "\\";

                        videoZhengJueJsonFileName = "cheng_ren_shuang_zheng_que_video_json.txt";
                        videoZhengJueJsonFilePath = jsonLocalCommonDirPath + videoZhengJueJsonFileName;

                        videoCuoWuJsonFileName = "cheng_ren_shuang_zheng_cuo_wu_json.txt";
                        videoCuoWuJsonFilePath = jsonLocalCommonDirPath + videoCuoWuJsonFileName;

                        videoMainJsonFileName = "cheng_ren_shuang_zheng_main_json.txt";
                        videoMainJsonFilePath = jsonLocalCommonDirPath + videoMainJsonFileName;
                    }
                    break;
                case LType.LTypeErtongDanBan:
                    {
                        videoLocalCommonDirPath = cPath + "儿童单板教程\\第" + (orderNum + 1) + "课\\";

                        jsonLocalCommonDirPath = JPath + "er_tong_dan_ban_jiao_cheng\\videoDetailJson\\" + "item" + (orderNum + 1) + "\\";

                        videoZhengJueJsonFileName = "er_tong_dan_zheng_que_video_json.txt";
                        videoZhengJueJsonFilePath = jsonLocalCommonDirPath + videoZhengJueJsonFileName;

                        videoCuoWuJsonFileName = "er_tong_dan_zheng_cuo_wu_json.txt";
                        videoCuoWuJsonFilePath = jsonLocalCommonDirPath + videoCuoWuJsonFileName;

                        videoMainJsonFileName = "er_tong_dan_zheng_main_json.txt";
                        videoMainJsonFilePath = jsonLocalCommonDirPath + videoMainJsonFileName;
                    }
                    break;
                case LType.LTypeChengRenDanBan:
                    {
                        videoLocalCommonDirPath = cPath + "成人单板教程\\第" + (orderNum + 1) + "课\\";

                        jsonLocalCommonDirPath = JPath + "cheng_ren_dan_ban_jiao_cheng\\videoDetailJson\\" + "item" + (orderNum + 1) + "\\";

                        videoZhengJueJsonFileName = "cheng_ren_dan_zheng_que_video_json.txt";
                        videoZhengJueJsonFilePath = jsonLocalCommonDirPath + videoZhengJueJsonFileName;

                        videoCuoWuJsonFileName = "cheng_ren_dan_zheng_cuo_wu_json.txt";
                        videoCuoWuJsonFilePath = jsonLocalCommonDirPath + videoCuoWuJsonFileName;

                        videoMainJsonFileName = "cheng_ren_dan_zheng_main_json.txt";
                        videoMainJsonFilePath = jsonLocalCommonDirPath + videoMainJsonFileName;
                    }
                    break;
            }
        }
    }
}
