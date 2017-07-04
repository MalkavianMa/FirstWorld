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
    public partial class Form1 : Form
    {
        string[] names = new string[] { "乾", "坤", "巽", "阴","阳","金","木", "坎", "离", "土", "震" , "艮","兑" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void ShowName()
        {
            Random r = new Random();
            int id = r.Next(0,names.Length);
            lblName.Text = names[id];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowName();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Enabled = !timer1.Enabled;//enable激活,FALSE设置为无效视为停止时间控件.默认状态是不启用..这里语句是每次按下回车都得改变timer的状态..如果timer等于FALSE则赋值为TRUE,反之亦然..
            }
        }

    }
}
