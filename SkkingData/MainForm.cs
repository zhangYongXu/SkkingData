using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SkkingData.model;

using System.IO;

using SkkingData.tools;

using System.Collections;

namespace SkkingData
{
    public partial class MainForm: Form
    {

        public ModuleModel moduleModel;

        public FileHandle fileHandle;

        public ImageList imageList;

        public LessonModel currentLessonModel;

        public MainVideoModel currentMainVideoModel;

        public ArrayList zhengQueVideoList = new ArrayList();
        public ArrayList cuoWuVideoList = new ArrayList();


        public MainForm()
        {
            InitializeComponent();
            initData();
            initView();
        }
       
        public void initData() {
            moduleModel = new ModuleModel(LType.LTypeErTongShuangBan);
            fileHandle = new FileHandle();
            imageList = new ImageList();
            imageList.ImageSize = new Size(50, 50);

            refreshLessonListView();

            if (this.lessonListView.Items.Count > 0)
            {
                this.lessonListView.Items[0].Selected = true;
                this.lessonListView.Select();
            }
        }
        public void initView()
        {
            switch (moduleModel.type)
            {

                case LType.LTypeErTongShuangBan:
                    {
                        moduleTItle.Text = "儿童双板教程";
                    }
                    break;
                case LType.LTypeChengRenShuangBan:
                    {
                        moduleTItle.Text = "成人双板教程";
                    }
                    break;
                case LType.LTypeErtongDanBan:
                    {
                        moduleTItle.Text = "儿童单板教程";
                    }
                    break;
                case LType.LTypeChengRenDanBan:
                    {
                        moduleTItle.Text = "成人单板教程";
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void lessonListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ListView.SelectedIndexCollection c = lessonListView.SelectedIndices;

            if (c.Count > 0)
            {
                //MessageBox.Show("index:"+c[0]);

                int index = c[0];
                LessonModel lessonModel = (LessonModel)moduleModel.lessonList[index];

                currentLessonModel = lessonModel;

                refreshVideoDetail();
                    
            }
            
        }

        private void refreshVideoDetail() {
            String filePath = currentLessonModel.videoMainJsonFilePath;
            String jsonString = FileHandle.readJsonFile(filePath);
            currentMainVideoModel = (MainVideoModel)JSONHandle.getObjFromJson<MainVideoModel>(jsonString);
            if (currentMainVideoModel == null)
            {
                currentMainVideoModel = new MainVideoModel();
            }
            else {
                mainVideoTItletextBox1.Text = currentMainVideoModel.videoTitle;
                lessonIntroTextBox.Text = currentMainVideoModel.videoLessonIntro;
                videoDetialLabel.Text = "第" + (currentLessonModel.orderNum + 1) + "课";
            }


            String zqfilePath = currentLessonModel.videoZhengJueJsonFilePath;
            String zqjsonString = FileHandle.readJsonFile(zqfilePath);

            List<ItemVideoModel> zqList = (List<ItemVideoModel>)JSONHandle.getObjFromJson<List<ItemVideoModel>>(zqjsonString);

            if (zqList == null)
            {
                return;
            }
            foreach (ItemVideoModel m in zqList)
            {
                zhengQueVideoList.Add(m);
            }

            refreshZhengQueVideoListView();



            String cwfilePath = currentLessonModel.videoCuoWuJsonFilePath;
            String cwjsonString = FileHandle.readJsonFile(cwfilePath);

            List<ItemVideoModel> cwList = (List<ItemVideoModel>)JSONHandle.getObjFromJson<List<ItemVideoModel>>(cwjsonString);

            if (cwList == null)
            {
                return;
            }
            foreach (ItemVideoModel m in cwList)
            {
                zhengQueVideoList.Add(m);
            }
            refreshCuoWuVideoListView();


        }

        private void lessonListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView.SelectedIndexCollection c = lessonListView.SelectedIndices;
            if (c.Count > 0)
            {
                //MessageBox.Show("index:"+c[0]);

                int index = c[0];
                LessonModel lessonModel = (LessonModel)moduleModel.lessonList[index];

                LessonDetailForm frm = new LessonDetailForm(lessonModel, moduleModel, LessonDetailType.LessonDetailTypeEdit);
                if (frm.ShowDialog() == DialogResult.OK)//对话框返回值为ok时运行
                {
                    moduleModel.lessonList.Add(lessonModel);
                    refreshLessonListView();

                    String jsonString = JSONHandle.Obj2Json(moduleModel.lessonList);
                    //MessageBox.Show("jsonString:"+jsonString);
                    String filePath = moduleModel.jsonFileLocalPath;
                    FileHandle.saveJsonFile(filePath,jsonString);
         
                }
            }
        }




        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        //添加课程
        private void button5_Click(object sender, EventArgs e)
        {
            LessonModel lessonModel = new LessonModel(moduleModel.type, moduleModel.lessonList.Count);
            //lessonModel.type = moduleModel.type;
           // lessonModel.orderNum = moduleModel.lessonList.Count;

            LessonDetailForm frm = new LessonDetailForm(lessonModel,moduleModel,LessonDetailType.LessonDetailTypeAdd);
            if (frm.ShowDialog() == DialogResult.OK)//对话框返回值为ok时运行
            {
                moduleModel.lessonList.Add(lessonModel);
                refreshLessonListView();

                String jsonString = JSONHandle.getJsonString(moduleModel.lessonList);
                //MessageBox.Show("jsonString:" + jsonString);
                String filePath = moduleModel.jsonFileLocalPath;
                FileHandle.saveJsonFile(filePath, jsonString);
            }

        }

        //刷新课程列表
        public void refreshLessonListView() {
            lessonListView.Items.Clear();
            imageList.Images.Clear();
            foreach (LessonModel model in moduleModel.lessonList) {
                ListViewItem item = new ListViewItem();

                String imagePath = moduleModel.commonPath + "images\\" + model.imageName;
                imageList.Images.Add(Image.FromFile(imagePath));
                item.Text = "第"+(model.orderNum+1)+"课";
                item.SubItems.Add(model.name);
                lessonListView.Items.Add(item);
            }
            
        }

        //刷新正确视频列表
        public void refreshZhengQueVideoListView()
        {
            lessonListView.Items.Clear();
            foreach (ItemVideoModel model in zhengQueVideoList)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "第" + (model.videoId + 1) + "条";
                item.SubItems.Add(model.videoTitle);
                zhengQuevideoListView.Items.Add(item);
            }

        }

        //刷新正确视频列表
        public void refreshCuoWuVideoListView()
        {
            lessonListView.Items.Clear();
            foreach (ItemVideoModel model in zhengQueVideoList)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "第" + (model.videoId + 1) + "条";
                item.SubItems.Add(model.videoTitle);
                cuoWuVideoListView.Items.Add(item);
            }

        }


        //添加主视频
        private void addMainVideoBtn_Click(object sender, EventArgs e)
        {
            if (null == currentLessonModel) {
                MessageBox.Show("请先选择课程");
                return;
            }

            AddEditMainVideoForm frm = new AddEditMainVideoForm(currentLessonModel,currentMainVideoModel);
            if (frm.ShowDialog() == DialogResult.OK)//对话框返回值为ok时运行
            {

                String filePath = currentLessonModel.videoMainJsonFilePath;
                String jsonString = JSONHandle.getJsonString(currentMainVideoModel);
                FileHandle.saveJsonFile(filePath, jsonString);

                refreshVideoDetail();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
