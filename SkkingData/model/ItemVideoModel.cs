using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SkkingData.model
{/*
     {
        "videoTitle":"基本站姿",
        "videoId":1,
        "videoType":"1",
        "faceImageName":"z1.jpg",
        "videoIntroduction":"原地做前倾伸直身体，脚在鞋里为前脚掌，后落身体，将整个身体重量落回整脚",
        "videoTarget":"",
        "videoName":"lesson01_main view.mp4"
    }
         */

    public enum ItemVideoModelType
    {
        ItemVideoModelTypeZhengQue = 1,
        ItemVideoModelTypeCuo = 2
    };
    public class ItemVideoModel
    {
        public String videoTitle;
        public int videoId;
        public ItemVideoModelType videoType;
        public String videoActionIntroduction;
        public String videoCuoWuAction;
        public String videoName;
    }
}
