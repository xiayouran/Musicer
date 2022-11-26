namespace freemusic
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pictureBoxBunifuItachi1 = new ItachiUIBunifu.PictureBoxBunifuItachi();
            this.pictureBoxBunifuItachi2 = new ItachiUIBunifu.PictureBoxBunifuItachi();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBunifuItachi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBunifuItachi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(74, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "选择";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(92, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 26);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(283, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "搜索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(343, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "选择下载目录";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBoxBunifuItachi1
            // 
            this.pictureBoxBunifuItachi1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pictureBoxBunifuItachi1.BorderColor = System.Drawing.Color.Empty;
            this.pictureBoxBunifuItachi1.BorderColor2 = System.Drawing.Color.Empty;
            this.pictureBoxBunifuItachi1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pictureBoxBunifuItachi1.BorderSize = 2;
            this.pictureBoxBunifuItachi1.GradientAngle = 50F;
            this.pictureBoxBunifuItachi1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBunifuItachi1.Image")));
            this.pictureBoxBunifuItachi1.Location = new System.Drawing.Point(377, 350);
            this.pictureBoxBunifuItachi1.Name = "pictureBoxBunifuItachi1";
            this.pictureBoxBunifuItachi1.Size = new System.Drawing.Size(39, 39);
            this.pictureBoxBunifuItachi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBunifuItachi1.TabIndex = 6;
            this.pictureBoxBunifuItachi1.TabStop = false;
            this.pictureBoxBunifuItachi1.Click += new System.EventHandler(this.pictureBoxBunifuItachi1_Click);
            // 
            // pictureBoxBunifuItachi2
            // 
            this.pictureBoxBunifuItachi2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pictureBoxBunifuItachi2.BorderColor = System.Drawing.Color.Empty;
            this.pictureBoxBunifuItachi2.BorderColor2 = System.Drawing.Color.Empty;
            this.pictureBoxBunifuItachi2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pictureBoxBunifuItachi2.BorderSize = 2;
            this.pictureBoxBunifuItachi2.GradientAngle = 50F;
            this.pictureBoxBunifuItachi2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBunifuItachi2.Image")));
            this.pictureBoxBunifuItachi2.Location = new System.Drawing.Point(422, 350);
            this.pictureBoxBunifuItachi2.Name = "pictureBoxBunifuItachi2";
            this.pictureBoxBunifuItachi2.Size = new System.Drawing.Size(39, 39);
            this.pictureBoxBunifuItachi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBunifuItachi2.TabIndex = 7;
            this.pictureBoxBunifuItachi2.TabStop = false;
            this.pictureBoxBunifuItachi2.Click += new System.EventHandler(this.pictureBoxBunifuItachi2_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 303);
            this.panel1.TabIndex = 8;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 344);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(449, 45);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 401);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxBunifuItachi2);
            this.Controls.Add(this.pictureBoxBunifuItachi1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Musicer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBunifuItachi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBunifuItachi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private ItachiUIBunifu.PictureBoxBunifuItachi pictureBoxBunifuItachi1;
        private ItachiUIBunifu.PictureBoxBunifuItachi pictureBoxBunifuItachi2;
        private System.Windows.Forms.Panel panel1;
    }
}

