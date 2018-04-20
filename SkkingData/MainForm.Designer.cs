namespace SkkingData
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lessonListView = new System.Windows.Forms.ListView();
            this.listviewItemLessonImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listviewLessonName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button5 = new System.Windows.Forms.Button();
            this.moduleTItle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.videoListView = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "儿童双板教程";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "成人双板教程";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = "儿童单板教程";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 213);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 70);
            this.button4.TabIndex = 3;
            this.button4.Text = "成人单板教程";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 561);
            this.panel1.TabIndex = 4;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(20, 466);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(125, 70);
            this.button9.TabIndex = 4;
            this.button9.Text = "打开数据目录";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lessonListView);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.moduleTItle);
            this.panel2.Location = new System.Drawing.Point(168, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 564);
            this.panel2.TabIndex = 5;
            // 
            // lessonListView
            // 
            this.lessonListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listviewItemLessonImage,
            this.listviewLessonName});
            this.lessonListView.FullRowSelect = true;
            this.lessonListView.GridLines = true;
            this.lessonListView.Location = new System.Drawing.Point(4, 42);
            this.lessonListView.Name = "lessonListView";
            this.lessonListView.Size = new System.Drawing.Size(282, 515);
            this.lessonListView.TabIndex = 3;
            this.lessonListView.TileSize = new System.Drawing.Size(128, 50);
            this.lessonListView.UseCompatibleStateImageBehavior = false;
            this.lessonListView.View = System.Windows.Forms.View.Details;
            this.lessonListView.SelectedIndexChanged += new System.EventHandler(this.lessonListView_SelectedIndexChanged);
            this.lessonListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lessonListView_MouseDoubleClick);
            // 
            // listviewItemLessonImage
            // 
            this.listviewItemLessonImage.Text = "课程图片";
            // 
            // listviewLessonName
            // 
            this.listviewLessonName.Text = "课程标题";
            this.listviewLessonName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.listviewLessonName.Width = 182;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(207, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "添加课程";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // moduleTItle
            // 
            this.moduleTItle.AutoSize = true;
            this.moduleTItle.Font = new System.Drawing.Font("宋体", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.moduleTItle.ForeColor = System.Drawing.Color.Red;
            this.moduleTItle.Location = new System.Drawing.Point(18, 13);
            this.moduleTItle.Name = "moduleTItle";
            this.moduleTItle.Size = new System.Drawing.Size(42, 16);
            this.moduleTItle.TabIndex = 1;
            this.moduleTItle.Text = "课程";
            this.moduleTItle.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.videoListView);
            this.panel3.Location = new System.Drawing.Point(470, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 561);
            this.panel3.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 137);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(397, 57);
            this.textBox1.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(14, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 60);
            this.panel4.TabIndex = 8;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(257, 108);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(154, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "课程简介";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(260, 13);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(151, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "添加主视频";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(260, 200);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(151, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "添加动作视频";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 4;
            // 
            // videoListView
            // 
            this.videoListView.Location = new System.Drawing.Point(14, 229);
            this.videoListView.Name = "videoListView";
            this.videoListView.Size = new System.Drawing.Size(397, 328);
            this.videoListView.TabIndex = 3;
            this.videoListView.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "滑雪本地数据处理";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label moduleTItle;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView videoListView;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ListView lessonListView;
        private System.Windows.Forms.ColumnHeader listviewItemLessonImage;
        private System.Windows.Forms.ColumnHeader listviewLessonName;
    }
}

