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
    public partial class frmMessage : Form
    {
        public frmMessage(frmMain frm)
        {
            InitializeComponent();
            frm.changetxt_event += new frmMain.changetxt(frm_changetxt_event);
        }
        public frmMessage()
        {
            InitializeComponent();
        }
        public delegate void changetext(string  text);
        public event changetext changetext_event;
        void frm_changetxt_event(string text)
        {
            label1.Text = text;
        }

        private void btnChild_Click(object sender, EventArgs e)
        {
            if (changetext_event==null)
            {
                MessageBox.Show("可能要出现异常");

            }
            changetext_event(label1.Text);
        }
    }
}
