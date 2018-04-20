namespace SkkingData
{
    partial class LessonDetailForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lessonNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lessonImageButton = new System.Windows.Forms.Button();
            this.congfirmButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 197);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lessonNameTextBox
            // 
            this.lessonNameTextBox.Location = new System.Drawing.Point(236, 92);
            this.lessonNameTextBox.Multiline = true;
            this.lessonNameTextBox.Name = "lessonNameTextBox";
            this.lessonNameTextBox.Size = new System.Drawing.Size(515, 104);
            this.lessonNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "课程标题";
            // 
            // lessonImageButton
            // 
            this.lessonImageButton.BackColor = System.Drawing.Color.White;
            this.lessonImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lessonImageButton.Location = new System.Drawing.Point(22, 57);
            this.lessonImageButton.Name = "lessonImageButton";
            this.lessonImageButton.Size = new System.Drawing.Size(135, 197);
            this.lessonImageButton.TabIndex = 3;
            this.lessonImageButton.Text = "课程图片";
            this.lessonImageButton.UseVisualStyleBackColor = false;
            this.lessonImageButton.Click += new System.EventHandler(this.lessonImageButton_Click);
            // 
            // congfirmButton
            // 
            this.congfirmButton.Location = new System.Drawing.Point(360, 365);
            this.congfirmButton.Name = "congfirmButton";
            this.congfirmButton.Size = new System.Drawing.Size(135, 58);
            this.congfirmButton.TabIndex = 4;
            this.congfirmButton.Text = "确认";
            this.congfirmButton.UseVisualStyleBackColor = true;
            this.congfirmButton.Click += new System.EventHandler(this.congfirmButton_Click);
            // 
            // LessonDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.congfirmButton);
            this.Controls.Add(this.lessonImageButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lessonNameTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LessonDetailForm";
            this.Text = "课程编辑";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox lessonNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lessonImageButton;
        private System.Windows.Forms.Button congfirmButton;
    }
}