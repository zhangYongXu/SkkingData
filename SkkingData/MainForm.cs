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

namespace SkkingData
{
    public partial class MainForm: Form
    {

        public ModuleModel moduleModel;

        public FileHandle fileHandle;

        public ImageList imageList;

        

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

                LessonDetailForm frm = new LessonDetailForm(lessonModel, moduleModel, LessonDetailType.LessonDetailTypeEdit);
                if (frm.ShowDialog() == DialogResult.OK)//对话框返回值为ok时运行
                {
                    moduleModel.lessonList.Add(lessonModel);
                    refreshLessonListView();
                }
            }
        }
        

        

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        //添加课程
        private void button5_Click(object sender, EventArgs e)
        {
            LessonModel lessonModel = new LessonModel();
            lessonModel.orderNum = moduleModel.lessonList.Count;

            LessonDetailForm frm = new LessonDetailForm(lessonModel,moduleModel,LessonDetailType.LessonDetailTypeAdd);
            if (frm.ShowDialog() == DialogResult.OK)//对话框返回值为ok时运行
            {
                moduleModel.lessonList.Add(lessonModel);
                refreshLessonListView();
            }

        }

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
            //lessonListView.SmallImageList = imageList;
        }

        
    }
}
