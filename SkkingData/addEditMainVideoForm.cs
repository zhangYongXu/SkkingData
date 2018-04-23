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
using SkkingData.tools;

namespace SkkingData
{
    public enum AddEditMainVideoFormType
    {
        AddEditMainVideoFormTypeAdd = 1,
        AddEditMainVideoFormTypeEdit = 2
    };
    public partial class AddEditMainVideoForm : Form
    {
        private LessonModel currentLessonModel;

        private MainVideoModel mainVideoModel;

        private String videoOrignalPath;



        public AddEditMainVideoForm(LessonModel lessonModel,MainVideoModel CmainVideoModel)
        {
            InitializeComponent();

            currentLessonModel = lessonModel;
            mainVideoModel = CmainVideoModel;

            initData();
            initView();
        }

        private void initData() {
            
        }
        private void initView() {
            if (mainVideoModel.videoTitle != null) {
                titleTextBox.Text = mainVideoModel.videoTitle;
            }

            if (mainVideoModel.videoLessonIntro != null)
            {
                introtextBox.Text = mainVideoModel.videoLessonIntro;
            }

            if (mainVideoModel.videoName != null)
            {
                String targetPath = currentLessonModel.getMainVideoDir() + mainVideoModel.videoName;
                videoOrignalPath = targetPath;
                VideoWindowsMediaPlayer1.URL = videoOrignalPath;
                VideoWindowsMediaPlayer1.Ctlcontrols.play();

            }



        }

        private void videoSelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            const string imgExts = "视频文件 (*.mp4;)|*.mp4;";
            openFileDialog.Filter = imgExts;//可选择的文件格式 (|之前为显示，之后为控制后缀显示)
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {

                String orignalPath = openFileDialog.FileName;

                videoOrignalPath = orignalPath;

                VideoWindowsMediaPlayer1.URL = videoOrignalPath;
                VideoWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        public bool validate()
        {
            if (titleTextBox.Text == null)
            {
                MessageBox.Show("请填写主视频标题");
                return false;
            }
            if (introtextBox.Text.Equals(""))
            {
                MessageBox.Show("请填写课程简介");
                return false;
            }
            if (videoOrignalPath == null)
            {
                MessageBox.Show("请选择视频");
                return false;
            }
            if (videoOrignalPath.Equals(""))
            {
                MessageBox.Show("请选择主视频");
                return false;
            }
            return true;
        }

        private void congfirmButton_Click(object sender, EventArgs e)
        {
            if (!validate()) {
                return;
            }

            mainVideoModel.videoTitle = titleTextBox.Text;
            mainVideoModel.videoLessonIntro = introtextBox.Text;
            mainVideoModel.videoName = "lesson_video_main.mp4";

            String targetPath = currentLessonModel.getMainVideoDir() + mainVideoModel.videoName;

            if (!targetPath.Equals(videoOrignalPath)) {
                FileHandle.copyFile(videoOrignalPath, targetPath);
            }

            this.DialogResult = DialogResult.OK;
            MessageBox.Show("保存成功");
        }

        private void AddEditMainVideoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
