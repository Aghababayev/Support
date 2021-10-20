namespace ASM_SUPPORT
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pingbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // pingbox
            // 
            this.pingbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pingbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pingbox.Location = new System.Drawing.Point(0, 0);
            this.pingbox.Multiline = true;
            this.pingbox.Name = "pingbox";
            this.pingbox.Size = new System.Drawing.Size(288, 940);
            this.pingbox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(294, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 85);
            this.button1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button1, "PİNG");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(294, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 85);
            this.button2.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button2, "TƏMİZLƏ");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(294, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 85);
            this.button3.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button3, " BAĞLA");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 1000;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 200;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "İNFORMASİYA";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 940);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pingbox);
            this.Font = new System.Drawing.Font("Dotum", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(200, 100);
            this.Name = "Form3";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pingbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}