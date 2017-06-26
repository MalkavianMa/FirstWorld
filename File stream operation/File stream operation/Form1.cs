using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_stream_operation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击事件激活选择文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnselect_Click(object sender, EventArgs e)
        {
            // FbdV.RootFolder = "d:\\";
            FbdV.SelectedPath = "d:\\";//起始默认穆勒
            // System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            //dialog.Description = "请选择Txt所在文件夹";
            FbdV.Description = "请选择需要遍历的文件夹图片";
            if (FbdV.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(FbdV.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                this.label1.Text = "处理中...";
                tbxPath.Text = FbdV.SelectedPath.Trim();
                //this.LoadingDisplay = true;
                // Action<string> a = DaoRuData;
                //    a.BeginInvoke(FbdV.SelectedPath, asyncCallback, a);
                try
                {
                    ScanPic(FbdV.SelectedPath.Trim());

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

        static List<FileInfo> result;

        /// <summary>
        /// 遍历文件夹下的文件
        /// </summary>
        /// <param name="p">文件夹路径</param>
        private void ScanPic(string p)
        {
            result = new List<FileInfo>();
            List<FileInfo> allfiles = new List<FileInfo>();//全部文件列表
            DirectoryInfo dirinfo = new DirectoryInfo(p);//文件目录
            //DirectoryInfo[] directories = dirinfo.GetDirectories("*轮巡视",SearchOption.TopDirectoryOnly);
            //for (int i = 0; i < directories.Length; i++)
            //{
            //    allfiles = GetFiles(directories[i]);
            //    allfiles.AddRange(allfiles);
            //}
            allfiles = GetFiles(dirinfo);
            WriteResult(@"f:\业务流\kvDown.txt", allfiles);
            //foreach (FileInfo item in allfiles)
            //{
            //    string fileName = item.Name;
            //    WriteResult(p,fileName);
            //}
        }
        /// <summary>
        /// txt格式写入所有文件名
        /// </summary>
        /// <param name="writePath"></param>
        /// <param name="allfiles"></param>
        private void WriteResult(string writePath, List<FileInfo> allfiles)
        {
            FileStream fs = new FileStream(writePath, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Flush();
            sw.BaseStream.Seek(0, SeekOrigin.Begin);
            //  int i=0;
            foreach (FileInfo item in allfiles)//遍历取出文件信息
            {
                // i++;
                sw.WriteLine(item.Name + "\0");//+i);
            }
            sw.Flush();
            sw.Close();
            fs.Close();
            MessageBox.Show("已写入");
            this.label1.Text = "处理已完成";

            //throw new NotImplementedException();
        }
        /// <summary>
        /// 目录及子目录下的文件列表
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        private static List<FileInfo> GetFiles(DirectoryInfo directory)
        {

            if (directory.Exists)//目录存在
            {
                try
                {
                    foreach (FileInfo info in directory.GetFiles())//遍历取当前文件列表
                    {
                        result.Add(info);
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                foreach (DirectoryInfo info in directory.GetDirectories())//遍历取当前目录的子目录
                {
                    GetFiles(info);//调用自身取子目录文件列表
                }
            }
            return result;
        }




        //选择文件，点击【浏览】，选择文件 

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();   //显示选择文件对话框 
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog1.FileName;     //显示文件路径 
            }
        }
    }
}
