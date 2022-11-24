namespace TMS.Controls.TeamRegisterandManage
{
    partial class addrole
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
            this.txtRole = new System.Windows.Forms.TextBox();
            this.lblrole = new System.Windows.Forms.Label();
            this.btnaddrole = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRole
            // 
            this.txtRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(98, 58);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(150, 27);
            this.txtRole.TabIndex = 0;
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrole.Location = new System.Drawing.Point(-1, 60);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(97, 21);
            this.lblrole.TabIndex = 1;
            this.lblrole.Text = "Define Role";
            // 
            // btnaddrole
            // 
            this.btnaddrole.ForeColor = System.Drawing.Color.White;
            this.btnaddrole.Location = new System.Drawing.Point(98, 97);
            this.btnaddrole.Name = "btnaddrole";
            this.btnaddrole.Size = new System.Drawing.Size(75, 32);
            this.btnaddrole.TabIndex = 2;
            this.btnaddrole.Text = "Add Role";
            this.btnaddrole.UseVisualStyleBackColor = true;
            this.btnaddrole.Click += new System.EventHandler(this.btnaddrole_Click);
            // 
            // btnclose
            // 
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnclose.Location = new System.Drawing.Point(209, 1);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(40, 32);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // addrole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(253, 141);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnaddrole);
            this.Controls.Add(this.lblrole);
            this.Controls.Add(this.txtRole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addrole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addrole";
            this.Load += new System.EventHandler(this.addrole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label lblrole;
        private System.Windows.Forms.Button btnaddrole;
        private System.Windows.Forms.Button btnclose;
    }
}