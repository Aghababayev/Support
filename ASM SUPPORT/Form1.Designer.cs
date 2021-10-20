namespace ASM_SUPPORT
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 131);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1078, 318);
            this.webBrowser1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Chartreuse;
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1078, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(324, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 100);
            this.button4.TabIndex = 2;
            this.toolTip2.SetToolTip(this.button4, "SİSTEMİ SÖNDÜR");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(681, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 69);
            this.label2.TabIndex = 1;
            this.label2.Text = "SAAT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(868, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "TARIX";
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(218, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 0;
            this.toolTip2.SetToolTip(this.button3, "SİSTEMİ YENİDƏN BAŞLAT");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(112, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button2, "ŞƏBƏKƏ PİNG PROGRAMI");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(6, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button1, "BURADA MAĞAZA ŞƏBƏKƏ MƏLUMATLARI VAR");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 1000;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 200;
            this.toolTip1.Tag = "";
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "İNFORMASİYA";
            // 
            // toolTip2
            // 
            this.toolTip2.AutomaticDelay = 1000;
            this.toolTip2.AutoPopDelay = 10000;
            this.toolTip2.InitialDelay = 10;
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ReshowDelay = 200;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip2.ToolTipTitle = "İNFORMASİYA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 449);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ASM SUPPORT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

