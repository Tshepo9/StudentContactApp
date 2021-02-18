namespace Student_Contact_Information
{
    partial class mainform
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
            this.searchbarRtb = new System.Windows.Forms.RichTextBox();
            this.logopicbox = new System.Windows.Forms.PictureBox();
            this.colorpnl2 = new System.Windows.Forms.Panel();
            this.searchbtn = new System.Windows.Forms.Button();
            this.panelview = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelenter = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logopicbox)).BeginInit();
            this.panelview.SuspendLayout();
            this.panelenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchbarRtb
            // 
            this.searchbarRtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchbarRtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbarRtb.Location = new System.Drawing.Point(238, 101);
            this.searchbarRtb.Multiline = false;
            this.searchbarRtb.Name = "searchbarRtb";
            this.searchbarRtb.Size = new System.Drawing.Size(437, 45);
            this.searchbarRtb.TabIndex = 0;
            this.searchbarRtb.Text = " ";
            this.searchbarRtb.ZoomFactor = 2F;
            // 
            // logopicbox
            // 
            this.logopicbox.BackgroundImage = global::Student_Contact_Information.Properties.Resources.findtheuser_search_search_theuser_4518;
            this.logopicbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logopicbox.Location = new System.Drawing.Point(79, 61);
            this.logopicbox.Name = "logopicbox";
            this.logopicbox.Size = new System.Drawing.Size(135, 123);
            this.logopicbox.TabIndex = 1;
            this.logopicbox.TabStop = false;
            // 
            // colorpnl2
            // 
            this.colorpnl2.BackColor = System.Drawing.Color.DarkRed;
            this.colorpnl2.Location = new System.Drawing.Point(-1, -6);
            this.colorpnl2.Name = "colorpnl2";
            this.colorpnl2.Size = new System.Drawing.Size(58, 504);
            this.colorpnl2.TabIndex = 2;
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.DarkRed;
            this.searchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.Color.White;
            this.searchbtn.Location = new System.Drawing.Point(681, 101);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(104, 45);
            this.searchbtn.TabIndex = 3;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            // 
            // panelview
            // 
            this.panelview.BackColor = System.Drawing.Color.DarkRed;
            this.panelview.Controls.Add(this.label1);
            this.panelview.Controls.Add(this.label3);
            this.panelview.Controls.Add(this.label2);
            this.panelview.Location = new System.Drawing.Point(238, 213);
            this.panelview.Name = "panelview";
            this.panelview.Size = new System.Drawing.Size(200, 272);
            this.panelview.TabIndex = 5;
            this.panelview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelview_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "view ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 43);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 43);
            this.label2.TabIndex = 5;
            this.label2.Text = "Student";
            // 
            // panelenter
            // 
            this.panelenter.BackColor = System.Drawing.Color.DarkRed;
            this.panelenter.Controls.Add(this.label4);
            this.panelenter.Controls.Add(this.label5);
            this.panelenter.Controls.Add(this.label6);
            this.panelenter.Location = new System.Drawing.Point(585, 213);
            this.panelenter.Name = "panelenter";
            this.panelenter.Size = new System.Drawing.Size(200, 272);
            this.panelenter.TabIndex = 6;
            this.panelenter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelenter_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 43);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 43);
            this.label5.TabIndex = 6;
            this.label5.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(32, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 43);
            this.label6.TabIndex = 5;
            this.label6.Text = "Student";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(819, 498);
            this.Controls.Add(this.panelenter);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.colorpnl2);
            this.Controls.Add(this.logopicbox);
            this.Controls.Add(this.searchbarRtb);
            this.Controls.Add(this.panelview);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainform";
            this.Text = "main";
            this.Load += new System.EventHandler(this.mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logopicbox)).EndInit();
            this.panelview.ResumeLayout(false);
            this.panelview.PerformLayout();
            this.panelenter.ResumeLayout(false);
            this.panelenter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox searchbarRtb;
        private System.Windows.Forms.PictureBox logopicbox;
        private System.Windows.Forms.Panel colorpnl2;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Panel panelview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelenter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}