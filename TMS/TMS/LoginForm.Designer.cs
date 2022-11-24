namespace TMS
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.logopicbox = new System.Windows.Forms.PictureBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblpwd = new System.Windows.Forms.Label();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logopicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // logopicbox
            // 
            this.logopicbox.Image = ((System.Drawing.Image)(resources.GetObject("logopicbox.Image")));
            this.logopicbox.Location = new System.Drawing.Point(12, 12);
            this.logopicbox.Name = "logopicbox";
            this.logopicbox.Size = new System.Drawing.Size(154, 188);
            this.logopicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logopicbox.TabIndex = 0;
            this.logopicbox.TabStop = false;
            // 
            // lblusername
            // 
            this.lblusername.Location = new System.Drawing.Point(172, 24);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(220, 23);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "&User name";
            this.lblusername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(174, 44);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(220, 20);
            this.txtusername.TabIndex = 1;
            // 
            // lblpwd
            // 
            this.lblpwd.AutoSize = true;
            this.lblpwd.Location = new System.Drawing.Point(172, 81);
            this.lblpwd.Name = "lblpwd";
            this.lblpwd.Size = new System.Drawing.Size(53, 13);
            this.lblpwd.TabIndex = 3;
            this.lblpwd.Text = "&Password";
            this.lblpwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(174, 101);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.Size = new System.Drawing.Size(220, 20);
            this.txtpwd.TabIndex = 2;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(197, 161);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(94, 23);
            this.btnok.TabIndex = 5;
            this.btnok.Text = "&OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Location = new System.Drawing.Point(300, 161);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(94, 23);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "&Exit";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 204);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.lblpwd);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.logopicbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login To : Task Management System";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logopicbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logopicbox;
        public System.Windows.Forms.Label lblusername;
        internal System.Windows.Forms.TextBox txtusername;
        internal System.Windows.Forms.Label lblpwd;
        internal System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncancel;
    }
}