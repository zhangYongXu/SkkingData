namespace SkkingData
{
    partial class AddEditMainVideoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditMainVideoForm));
            this.IntroductionTItle = new System.Windows.Forms.Label();
            this.congfirmButton = new System.Windows.Forms.Button();
            this.videoSelectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.introtextBox = new System.Windows.Forms.TextBox();
            this.VideoWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.VideoWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // IntroductionTItle
            // 
            this.IntroductionTItle.AutoSize = true;
            this.IntroductionTItle.BackColor = System.Drawing.SystemColors.Control;
            this.IntroductionTItle.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IntroductionTItle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IntroductionTItle.Location = new System.Drawing.Point(31, 11);
            this.IntroductionTItle.Name = "IntroductionTItle";
            this.IntroductionTItle.Size = new System.Drawing.Size(130, 24);
            this.IntroductionTItle.TabIndex = 10;
            this.IntroductionTItle.Text = "添加主视频";
            // 
            // congfirmButton
            // 
            this.congfirmButton.Location = new System.Drawing.Point(371, 367);
            this.congfirmButton.Name = "congfirmButton";
            this.congfirmButton.Size = new System.Drawing.Size(135, 58);
            this.congfirmButton.TabIndex = 9;
            this.congfirmButton.Text = "确认";
            this.congfirmButton.UseVisualStyleBackColor = true;
            this.congfirmButton.Click += new System.EventHandler(this.congfirmButton_Click);
            // 
            // videoSelectButton
            // 
            this.videoSelectButton.BackColor = System.Drawing.Color.White;
            this.videoSelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.videoSelectButton.Location = new System.Drawing.Point(25, 59);
            this.videoSelectButton.Name = "videoSelectButton";
            this.videoSelectButton.Size = new System.Drawing.Size(201, 43);
            this.videoSelectButton.TabIndex = 8;
            this.videoSelectButton.Text = "选择主视频";
            this.videoSelectButton.UseVisualStyleBackColor = false;
            this.videoSelectButton.Click += new System.EventHandler(this.videoSelectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "视频标题";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(247, 94);
            this.titleTextBox.Multiline = true;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(515, 36);
            this.titleTextBox.TabIndex = 6;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "课程简介";
            // 
            // introtextBox
            // 
            this.introtextBox.Location = new System.Drawing.Point(247, 200);
            this.introtextBox.Multiline = true;
            this.introtextBox.Name = "introtextBox";
            this.introtextBox.Size = new System.Drawing.Size(515, 126);
            this.introtextBox.TabIndex = 11;
            // 
            // VideoWindowsMediaPlayer1
            // 
            this.VideoWindowsMediaPlayer1.Enabled = true;
            this.VideoWindowsMediaPlayer1.Location = new System.Drawing.Point(25, 125);
            this.VideoWindowsMediaPlayer1.Name = "VideoWindowsMediaPlayer1";
            this.VideoWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoWindowsMediaPlayer1.OcxState")));
            this.VideoWindowsMediaPlayer1.Size = new System.Drawing.Size(201, 201);
            this.VideoWindowsMediaPlayer1.TabIndex = 13;
            // 
            // AddEditMainVideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VideoWindowsMediaPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.introtextBox);
            this.Controls.Add(this.IntroductionTItle);
            this.Controls.Add(this.congfirmButton);
            this.Controls.Add(this.videoSelectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleTextBox);
            this.Name = "AddEditMainVideoForm";
            this.Text = "主视频编辑";
            this.Load += new System.EventHandler(this.AddEditMainVideoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VideoWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IntroductionTItle;
        private System.Windows.Forms.Button congfirmButton;
        private System.Windows.Forms.Button videoSelectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox introtextBox;
        private AxWMPLib.AxWindowsMediaPlayer VideoWindowsMediaPlayer1;
    }
}