namespace TMS.Home
{
    partial class GroupTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupTask));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltaskgroup = new System.Windows.Forms.Label();
            this.btnmanage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbltaskgroup);
            this.panel1.Controls.Add(this.btnmanage);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 429);
            this.panel1.TabIndex = 0;
            // 
            // lbltaskgroup
            // 
            this.lbltaskgroup.AutoSize = true;
            this.lbltaskgroup.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaskgroup.Location = new System.Drawing.Point(12, 27);
            this.lbltaskgroup.Name = "lbltaskgroup";
            this.lbltaskgroup.Size = new System.Drawing.Size(139, 25);
            this.lbltaskgroup.TabIndex = 3;
            this.lbltaskgroup.Text = "Task Group :";
            // 
            // btnmanage
            // 
            this.btnmanage.Location = new System.Drawing.Point(63, 330);
            this.btnmanage.Name = "btnmanage";
            this.btnmanage.Size = new System.Drawing.Size(125, 43);
            this.btnmanage.TabIndex = 2;
            this.btnmanage.Text = "Manage";
            this.btnmanage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(925, 257);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GroupTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 429);
            this.Controls.Add(this.panel1);
            this.Name = "GroupTask";
            this.Text = "Task Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnmanage;
        private System.Windows.Forms.Label lbltaskgroup;
    }
}