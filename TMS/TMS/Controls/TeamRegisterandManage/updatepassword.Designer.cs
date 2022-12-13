namespace TMS.Controls.TeamRegisterandManage
{
    partial class updatepassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updatepassword));
            this.pnlaccount = new System.Windows.Forms.Panel();
            this.lblinstruction = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblchangeyourpwd = new System.Windows.Forms.Label();
            this.grbpwd = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtoldpwd = new System.Windows.Forms.TextBox();
            this.picoldpwd = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtnewpwd = new System.Windows.Forms.TextBox();
            this.picnewpwd = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtnewconfirmpwd = new System.Windows.Forms.TextBox();
            this.picnewconfirmpwd = new System.Windows.Forms.PictureBox();
            this.pnlaccount.SuspendLayout();
            this.grbpwd.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picoldpwd)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picnewpwd)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picnewconfirmpwd)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlaccount
            // 
            this.pnlaccount.Controls.Add(this.lblinstruction);
            this.pnlaccount.Controls.Add(this.btnlogin);
            this.pnlaccount.Controls.Add(this.lblchangeyourpwd);
            this.pnlaccount.Controls.Add(this.grbpwd);
            this.pnlaccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlaccount.Location = new System.Drawing.Point(0, 0);
            this.pnlaccount.Name = "pnlaccount";
            this.pnlaccount.Size = new System.Drawing.Size(1174, 505);
            this.pnlaccount.TabIndex = 11;
            // 
            // lblinstruction
            // 
            this.lblinstruction.AutoSize = true;
            this.lblinstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinstruction.Location = new System.Drawing.Point(359, 108);
            this.lblinstruction.Name = "lblinstruction";
            this.lblinstruction.Size = new System.Drawing.Size(428, 16);
            this.lblinstruction.TabIndex = 13;
            this.lblinstruction.Text = "A strong password helps prevent unauthorized access to your software.";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(649, 435);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(148, 35);
            this.btnlogin.TabIndex = 12;
            this.btnlogin.Text = "Change Password";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblchangeyourpwd
            // 
            this.lblchangeyourpwd.AutoSize = true;
            this.lblchangeyourpwd.BackColor = System.Drawing.Color.White;
            this.lblchangeyourpwd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchangeyourpwd.ForeColor = System.Drawing.Color.Black;
            this.lblchangeyourpwd.Location = new System.Drawing.Point(357, 72);
            this.lblchangeyourpwd.Name = "lblchangeyourpwd";
            this.lblchangeyourpwd.Size = new System.Drawing.Size(248, 25);
            this.lblchangeyourpwd.TabIndex = 11;
            this.lblchangeyourpwd.Text = "Change Your Password";
            // 
            // grbpwd
            // 
            this.grbpwd.Controls.Add(this.panel4);
            this.grbpwd.Controls.Add(this.panel2);
            this.grbpwd.Controls.Add(this.panel3);
            this.grbpwd.Location = new System.Drawing.Point(334, 142);
            this.grbpwd.Name = "grbpwd";
            this.grbpwd.Size = new System.Drawing.Size(476, 275);
            this.grbpwd.TabIndex = 14;
            this.grbpwd.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.txtoldpwd);
            this.panel4.Controls.Add(this.picoldpwd);
            this.panel4.Location = new System.Drawing.Point(13, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 48);
            this.panel4.TabIndex = 6;
            // 
            // txtoldpwd
            // 
            this.txtoldpwd.BackColor = System.Drawing.SystemColors.Control;
            this.txtoldpwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtoldpwd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoldpwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
            this.txtoldpwd.Location = new System.Drawing.Point(55, 11);
            this.txtoldpwd.Name = "txtoldpwd";
            this.txtoldpwd.Size = new System.Drawing.Size(370, 20);
            this.txtoldpwd.TabIndex = 6;
            this.txtoldpwd.Text = "Type your old Password";
            this.txtoldpwd.MouseEnter += new System.EventHandler(this.txtoldpwd_MouseEnter);
            this.txtoldpwd.MouseLeave += new System.EventHandler(this.txtoldpwd_MouseLeave);
            // 
            // picoldpwd
            // 
            this.picoldpwd.Image = ((System.Drawing.Image)(resources.GetObject("picoldpwd.Image")));
            this.picoldpwd.Location = new System.Drawing.Point(7, 5);
            this.picoldpwd.Name = "picoldpwd";
            this.picoldpwd.Size = new System.Drawing.Size(38, 38);
            this.picoldpwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picoldpwd.TabIndex = 5;
            this.picoldpwd.TabStop = false;
            this.picoldpwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picoldpwd_MouseDown);
            this.picoldpwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picoldpwd_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.txtnewpwd);
            this.panel2.Controls.Add(this.picnewpwd);
            this.panel2.Location = new System.Drawing.Point(13, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 48);
            this.panel2.TabIndex = 7;
            // 
            // txtnewpwd
            // 
            this.txtnewpwd.BackColor = System.Drawing.SystemColors.Control;
            this.txtnewpwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnewpwd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
            this.txtnewpwd.Location = new System.Drawing.Point(55, 11);
            this.txtnewpwd.Name = "txtnewpwd";
            this.txtnewpwd.Size = new System.Drawing.Size(370, 20);
            this.txtnewpwd.TabIndex = 6;
            this.txtnewpwd.Text = "Type your New Password";
            this.txtnewpwd.MouseEnter += new System.EventHandler(this.txtnewpwd_MouseEnter);
            this.txtnewpwd.MouseLeave += new System.EventHandler(this.txtnewpwd_MouseLeave);
            // 
            // picnewpwd
            // 
            this.picnewpwd.Image = ((System.Drawing.Image)(resources.GetObject("picnewpwd.Image")));
            this.picnewpwd.Location = new System.Drawing.Point(7, 5);
            this.picnewpwd.Name = "picnewpwd";
            this.picnewpwd.Size = new System.Drawing.Size(38, 38);
            this.picnewpwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picnewpwd.TabIndex = 5;
            this.picnewpwd.TabStop = false;
            this.picnewpwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picnewpwd_MouseDown);
            this.picnewpwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picnewpwd_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.txtnewconfirmpwd);
            this.panel3.Controls.Add(this.picnewconfirmpwd);
            this.panel3.Location = new System.Drawing.Point(13, 194);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 48);
            this.panel3.TabIndex = 8;
            // 
            // txtnewconfirmpwd
            // 
            this.txtnewconfirmpwd.BackColor = System.Drawing.SystemColors.Control;
            this.txtnewconfirmpwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnewconfirmpwd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewconfirmpwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
            this.txtnewconfirmpwd.Location = new System.Drawing.Point(55, 11);
            this.txtnewconfirmpwd.Name = "txtnewconfirmpwd";
            this.txtnewconfirmpwd.Size = new System.Drawing.Size(370, 20);
            this.txtnewconfirmpwd.TabIndex = 6;
            this.txtnewconfirmpwd.Text = "Type your Confirm Password";
            this.txtnewconfirmpwd.MouseEnter += new System.EventHandler(this.txtnewconfirmpwd_MouseEnter);
            this.txtnewconfirmpwd.MouseLeave += new System.EventHandler(this.txtnewconfirmpwd_MouseLeave);
            // 
            // picnewconfirmpwd
            // 
            this.picnewconfirmpwd.Image = ((System.Drawing.Image)(resources.GetObject("picnewconfirmpwd.Image")));
            this.picnewconfirmpwd.Location = new System.Drawing.Point(7, 5);
            this.picnewconfirmpwd.Name = "picnewconfirmpwd";
            this.picnewconfirmpwd.Size = new System.Drawing.Size(38, 38);
            this.picnewconfirmpwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picnewconfirmpwd.TabIndex = 5;
            this.picnewconfirmpwd.TabStop = false;
            this.picnewconfirmpwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picnewconfirmpwd_MouseDown);
            this.picnewconfirmpwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picnewconfirmpwd_MouseUp);
            // 
            // updatepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1174, 505);
            this.Controls.Add(this.pnlaccount);
            this.Name = "updatepassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Password";
            this.pnlaccount.ResumeLayout(false);
            this.pnlaccount.PerformLayout();
            this.grbpwd.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picoldpwd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picnewpwd)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picnewconfirmpwd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlaccount;
        private System.Windows.Forms.Label lblinstruction;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblchangeyourpwd;
        private System.Windows.Forms.GroupBox grbpwd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtoldpwd;
        private System.Windows.Forms.PictureBox picoldpwd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtnewpwd;
        private System.Windows.Forms.PictureBox picnewpwd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtnewconfirmpwd;
        private System.Windows.Forms.PictureBox picnewconfirmpwd;
    }
}