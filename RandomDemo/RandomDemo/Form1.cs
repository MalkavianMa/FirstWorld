using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomDemo
{
    public partial class frmMain : Form
    {
        //string[] names = new string[] { "乾", "坤", "巽", "阴","阳","金","木", "坎", "离", "土", "震" , "艮","兑" };
        string[] names = new string[] { "1", "2", "3", "4", "5", "6" };
        public frmMain()
        {
            InitializeComponent();
        }
        public delegate void changetxt(string text);
        public event changetxt changetxt_event;
        void frm_changetext_event(string text)
        {
            tbxMain.Text = text;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopLevel = true;
        }

        void ShowName()
        {
            Random r = new Random();
            int id = r.Next(0,names.Length);
            lblName.Text = names[id];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowName();//计时器启用才会执行ShowName
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Enabled = !timer1.Enabled;//enable激活,FALSE设置为无效视为停止时间控件.默认状态是不启用..这里语句是每次按下回车都得改变timer的状态..如果timer等于FALSE则赋值为TRUE,反之亦然..
            }
        }

        private void btnDice_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void btnCustomEvent_Click(object sender, EventArgs e)///原文地址//http://www.cnblogs.com/giserpan/p/6906624.html
        {
            frmMessage cf = new frmMessage(this);
            // cf.TopLevel = false;//非顶级窗体不能设为对话框
            //cf.TopLevel = true;
          //  cf.Dock = System.Windows.Forms.DockStyle.Fill;//填充方式
            cf.changetext_event += new frmMessage.changetext(frm_changetext_event);
           // panel1.Controls.Add(cf);//无法将顶级控件添加到控件。

            cf.Show(this);

            frmMessage ca = new frmMessage(this);
             ca.TopLevel = false;
            ca.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Controls.Add(ca);
            ca.Show();
            ca.changetext_event += new frmMessage.changetext(frm_changetext_event);

            //panel1.Show();
            // frmMain cf = new frmMain();
            //   cf.TopLevel = true;
        }

        private void btnEditChild_Click(object sender, EventArgs e)
        {
            changetxt_event(tbxMain.Text);
            
        }
    }
}
