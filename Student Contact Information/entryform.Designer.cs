namespace Student_Contact_Information
{
    partial class entryform
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
            this.btnctn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sidepnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnctn
            // 
            this.btnctn.BackColor = System.Drawing.Color.White;
            this.btnctn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnctn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnctn.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnctn.ForeColor = System.Drawing.Color.DarkRed;
            this.btnctn.Location = new System.Drawing.Point(255, 335);
            this.btnctn.Name = "btnctn";
            this.btnctn.Size = new System.Drawing.Size(291, 92);
            this.btnctn.TabIndex = 0;
            this.btnctn.Text = "CONTINUE";
            this.btnctn.UseVisualStyleBackColor = false;
            this.btnctn.Click += new System.EventHandler(this.btnctn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 108);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(181, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 108);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(297, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(474, 108);
            this.label3.TabIndex = 3;
            this.label3.Text = "Information";
            // 
            // sidepnl
            // 
            this.sidepnl.BackColor = System.Drawing.Color.DarkRed;
            this.sidepnl.Location = new System.Drawing.Point(0, -15);
            this.sidepnl.Name = "sidepnl";
            this.sidepnl.Size = new System.Drawing.Size(52, 467);
            this.sidepnl.TabIndex = 4;
            // 
            // entryform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sidepnl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnctn);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "entryform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.entryform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnctn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel sidepnl;
    }
}

