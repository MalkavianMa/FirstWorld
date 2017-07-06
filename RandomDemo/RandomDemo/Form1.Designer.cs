namespace RandomDemo
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDice = new System.Windows.Forms.Button();
            this.btnCustomEvent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxMain = new System.Windows.Forms.TextBox();
            this.btnEditChild = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(91, 120);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 56);
            this.lblName.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDice
            // 
            this.btnDice.Location = new System.Drawing.Point(43, 195);
            this.btnDice.Name = "btnDice";
            this.btnDice.Size = new System.Drawing.Size(75, 23);
            this.btnDice.TabIndex = 1;
            this.btnDice.Text = "骰子事件";
            this.btnDice.UseVisualStyleBackColor = true;
            this.btnDice.Click += new System.EventHandler(this.btnDice_Click);
            // 
            // btnCustomEvent
            // 
            this.btnCustomEvent.Location = new System.Drawing.Point(164, 195);
            this.btnCustomEvent.Name = "btnCustomEvent";
            this.btnCustomEvent.Size = new System.Drawing.Size(75, 23);
            this.btnCustomEvent.TabIndex = 2;
            this.btnCustomEvent.Text = "自定义事件";
            this.btnCustomEvent.UseVisualStyleBackColor = true;
            this.btnCustomEvent.Click += new System.EventHandler(this.btnCustomEvent_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(83, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // tbxMain
            // 
            this.tbxMain.Location = new System.Drawing.Point(83, 224);
            this.tbxMain.Name = "tbxMain";
            this.tbxMain.Size = new System.Drawing.Size(100, 21);
            this.tbxMain.TabIndex = 0;
            // 
            // btnEditChild
            // 
            this.btnEditChild.Location = new System.Drawing.Point(198, 227);
            this.btnEditChild.Name = "btnEditChild";
            this.btnEditChild.Size = new System.Drawing.Size(75, 23);
            this.btnEditChild.TabIndex = 4;
            this.btnEditChild.Text = "修改子窗体文字";
            this.btnEditChild.UseVisualStyleBackColor = true;
            this.btnEditChild.Click += new System.EventHandler(this.btnEditChild_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(285, 262);
            this.Controls.Add(this.btnEditChild);
            this.Controls.Add(this.tbxMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCustomEvent);
            this.Controls.Add(this.btnDice);
            this.Controls.Add(this.lblName);
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Text = "简单模型随机骰子";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDice;
        private System.Windows.Forms.Button btnCustomEvent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxMain;
        private System.Windows.Forms.Button btnEditChild;
    }
}

