namespace picHelp
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnWatermark = new System.Windows.Forms.Button();
            this.btnfilepath = new System.Windows.Forms.Button();
            this.txtboxPath = new System.Windows.Forms.TextBox();
            this.btnThumbnail = new System.Windows.Forms.Button();
            this.folder = new System.Windows.Forms.FolderBrowserDialog();
            this.dialog = new System.Windows.Forms.OpenFileDialog();
            this.CBOboxStyleThum = new System.Windows.Forms.ComboBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPicWatermark = new System.Windows.Forms.Button();
            this.cbxLocation = new System.Windows.Forms.ComboBox();
            this.RtbWaterMark = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "缩略图";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWatermark
            // 
            this.btnWatermark.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWatermark.BackgroundImage = global::picHelp.Properties.Resources.蝴蝶星云;
            this.btnWatermark.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnWatermark.FlatAppearance.BorderSize = 0;
            this.btnWatermark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWatermark.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWatermark.Location = new System.Drawing.Point(559, 255);
            this.btnWatermark.Name = "btnWatermark";
            this.btnWatermark.Size = new System.Drawing.Size(120, 39);
            this.btnWatermark.TabIndex = 1;
            this.btnWatermark.Text = "上文字水印(需备份原图,操作不可逆)";
            this.btnWatermark.UseVisualStyleBackColor = false;
            this.btnWatermark.Click += new System.EventHandler(this.btnWatermark_Click);
            // 
            // btnfilepath
            // 
            this.btnfilepath.Location = new System.Drawing.Point(2, 41);
            this.btnfilepath.Name = "btnfilepath";
            this.btnfilepath.Size = new System.Drawing.Size(122, 23);
            this.btnfilepath.TabIndex = 2;
            this.btnfilepath.Text = "选择文件路径";
            this.btnfilepath.UseVisualStyleBackColor = true;
            this.btnfilepath.Click += new System.EventHandler(this.btnfilepath_Click);
            // 
            // txtboxPath
            // 
            this.txtboxPath.Location = new System.Drawing.Point(12, 80);
            this.txtboxPath.Name = "txtboxPath";
            this.txtboxPath.Size = new System.Drawing.Size(100, 21);
            this.txtboxPath.TabIndex = 3;
            // 
            // btnThumbnail
            // 
            this.btnThumbnail.Location = new System.Drawing.Point(136, 167);
            this.btnThumbnail.Name = "btnThumbnail";
            this.btnThumbnail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThumbnail.Size = new System.Drawing.Size(75, 23);
            this.btnThumbnail.TabIndex = 4;
            this.btnThumbnail.Text = "缩略图";
            this.btnThumbnail.UseVisualStyleBackColor = true;
            this.btnThumbnail.Click += new System.EventHandler(this.btnThumbnail_Click);
            // 
            // dialog
            // 
            this.dialog.FileName = "openFileDialog1";
            // 
            // CBOboxStyleThum
            // 
            this.CBOboxStyleThum.FormattingEnabled = true;
            this.CBOboxStyleThum.Items.AddRange(new object[] {
            "HW",
            "W",
            "H",
            "Cut"});
            this.CBOboxStyleThum.Location = new System.Drawing.Point(9, 167);
            this.CBOboxStyleThum.Name = "CBOboxStyleThum";
            this.CBOboxStyleThum.Size = new System.Drawing.Size(121, 20);
            this.CBOboxStyleThum.TabIndex = 5;
            this.CBOboxStyleThum.Text = "HW";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(49, 220);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 21);
            this.txtHeight.TabIndex = 6;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(49, 193);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 21);
            this.txtWidth.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(10, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "宽";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(10, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "高";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "猎码者@2017 微博:赤毒墨幽";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(488, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "水印位置";
            // 
            // btnPicWatermark
            // 
            this.btnPicWatermark.Location = new System.Drawing.Point(34, 317);
            this.btnPicWatermark.Name = "btnPicWatermark";
            this.btnPicWatermark.Size = new System.Drawing.Size(143, 23);
            this.btnPicWatermark.TabIndex = 12;
            this.btnPicWatermark.Text = "增加图片水印";
            this.btnPicWatermark.UseVisualStyleBackColor = true;
            this.btnPicWatermark.Click += new System.EventHandler(this.btnPicWatermark_Click);
            // 
            // cbxLocation
            // 
            this.cbxLocation.FormattingEnabled = true;
            this.cbxLocation.Items.AddRange(new object[] {
            "左上",
            "上",
            "右上",
            "左",
            "中间",
            "右",
            "左下",
            "下",
            "右下"});
            this.cbxLocation.Location = new System.Drawing.Point(547, 293);
            this.cbxLocation.Name = "cbxLocation";
            this.cbxLocation.Size = new System.Drawing.Size(121, 20);
            this.cbxLocation.TabIndex = 13;
            // 
            // RtbWaterMark
            // 
            this.RtbWaterMark.Location = new System.Drawing.Point(547, 319);
            this.RtbWaterMark.Name = "RtbWaterMark";
            this.RtbWaterMark.Size = new System.Drawing.Size(121, 66);
            this.RtbWaterMark.TabIndex = 14;
            this.RtbWaterMark.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(484, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "水印内容";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::picHelp.Properties.Resources.蝴蝶星云;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(691, 397);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RtbWaterMark);
            this.Controls.Add(this.cbxLocation);
            this.Controls.Add(this.btnPicWatermark);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.CBOboxStyleThum);
            this.Controls.Add(this.btnThumbnail);
            this.Controls.Add(this.txtboxPath);
            this.Controls.Add(this.btnfilepath);
            this.Controls.Add(this.btnWatermark);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "图片处理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnWatermark;
        private System.Windows.Forms.Button btnfilepath;
        private System.Windows.Forms.TextBox txtboxPath;
        private System.Windows.Forms.Button btnThumbnail;
        private System.Windows.Forms.FolderBrowserDialog folder;
        private System.Windows.Forms.OpenFileDialog dialog;
        private System.Windows.Forms.ComboBox CBOboxStyleThum;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPicWatermark;
        private System.Windows.Forms.ComboBox cbxLocation;
        private System.Windows.Forms.RichTextBox RtbWaterMark;
        private System.Windows.Forms.Label label5;
    }
}

