using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace picHelp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldpath = @"C:\Users\dell\Pictures\气泡星云.jpg";
            string newpath = @"F:\testXiangmu\picHelp\picHelp\uppic\";

            ImageClass.MakeThumbnail(oldpath, newpath, 6700, 3200, "HW");
            txtboxPath = null;
        }

    

       

        private void btnfilepath_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog folder = new System.Windows.Forms.FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                this.txtboxPath.Text = folder.SelectedPath;

            }
        }

        private void btnThumbnail_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CBOboxStyleThum.Text)&&!string.IsNullOrEmpty(txtHeight.Text)&&!string.IsNullOrEmpty(txtWidth.Text))
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.txtboxPath.SelectedText = dialog.FileName;
                    string txtoldpath = dialog.FileName;//this.txtboxPath.Text;
                    string newpath = @"F:\testXiangmu\picHelp\picHelp\uppic\";
                    ImageClass.MakeThumbnail(txtoldpath, newpath, Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text), CBOboxStyleThum.Text);
                    this.txtboxPath.Text = null;

                }
            }
            else
            {
                MessageBox.Show("缩略方式,宽高度不能为空!");
                txtboxPath = null;

            }
       
           
        }

        private void btnWatermark_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                this.txtboxPath.SelectedText = dialog.FileName;
                string txtoldpath = this.txtboxPath.Text;
                if (!String.IsNullOrEmpty(RtbWaterMark.Text.Trim()))
                {
                    if (!String.IsNullOrEmpty(cbxLocation.Text.Trim()))
                    {
                        ImageClass.LetterWatermark(txtoldpath, 49, RtbWaterMark.Text, Color.Red, cbxLocation.Text.Trim());

                    }
             
                    

                }
                txtboxPath.Text = "";
            }
            else
            {
                MessageBox.Show("正常", "提示", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);

            }

        }

        /// <summary>
        /// 系统自带的按钮无法去除边框。网上找了个解决方案：        /*  重写按钮的OnPaint事件      */
        /// </summary>
        class newbtn : System.Windows.Forms.Button //继承之系统按钮控件

        {

            protected override void OnPaint(PaintEventArgs e)
            {//重写



                base.OnPaint(e);
                System.Drawing.Pen pen = new Pen(this.BackColor, 3);
                e.Graphics.DrawRectangle(pen, 0, 0, this.Width, this.Height);//填充

                pen.Dispose();

            }
        }

        //Winform的话，设置FlatStyle为Flat，并且设置FlatAppearance下的BorderSize为0.

        private void btnPicWatermark_Click(object sender, EventArgs e)
        {

        }
    }
}
