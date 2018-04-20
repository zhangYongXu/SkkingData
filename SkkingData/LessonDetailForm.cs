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
using System.IO;

namespace SkkingData
{
    public enum LessonDetailType {
        LessonDetailTypeAdd = 1,
        LessonDetailTypeEdit = 2
    };
    public partial class LessonDetailForm : Form
    {
        public LessonDetailType lType;
        public LessonModel lessonModel;
        public ModuleModel moduleModel;
        public FileHandle fileHandle;
        public String imageOrignalPath;
        public LessonDetailForm()
        {
            InitializeComponent();
            initView();
        }

        public LessonDetailForm(LessonModel model, ModuleModel mModel, LessonDetailType type) {
            lessonModel = model;
            moduleModel = mModel;
            lType = type;
            fileHandle = new FileHandle();
            InitializeComponent();
            initView();
        }
        public void initView(){
            if (lType == LessonDetailType.LessonDetailTypeEdit){
                String imagePath = moduleModel.commonPath + "images\\" + lessonModel.imageName;
                lessonImageButton.BackgroundImage = Image.FromFile(imagePath);

                lessonNameTextBox.Text = lessonModel.name;
            }
        }
        public bool validate() {
            if (lessonNameTextBox.Text == null) {
                MessageBox.Show("请填写课程名称");
                return false;
            }
            if (lessonNameTextBox.Text.Equals(""))
            {
                MessageBox.Show("请填写课程名称");
                return false;
            }
            if (imageOrignalPath == null) {
                MessageBox.Show("请选择课程图片");
                return false;
            }
            if (imageOrignalPath.Equals(""))
            {
                MessageBox.Show("请选择课程图片");
                return false;
            }
            return true;
        }
        private void congfirmButton_Click(object sender, EventArgs e)
        {
            if (!validate()) {                
                return;   
            }
            lessonModel.name = lessonNameTextBox.Text;

            string extension = Path.GetExtension(imageOrignalPath);//扩展名 ".png"
            String imageFileName = "faceimage" + lessonModel.orderNum + extension;
            lessonModel.imageName = imageFileName;
            
            String targetPath = moduleModel.commonPath + "images\\" + imageFileName;

            fileHandle.copyFile(imageOrignalPath, targetPath);

            this.DialogResult = DialogResult.OK;
            MessageBox.Show("保存成功");
        }

        private void lessonImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            const string imgExts = "图像文件 (*.bmp;*.ico;*.gif;*.jpeg;*.jpg;*.png)|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;*.png";
            openFileDialog.Filter = imgExts;//可选择的文件格式 (|之前为显示，之后为控制后缀显示)
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {

                String orignalPath = openFileDialog.FileName;
                lessonImageButton.BackgroundImage = Image.FromFile(orignalPath);
                imageOrignalPath = orignalPath;

                

            }
        }
    }
}
