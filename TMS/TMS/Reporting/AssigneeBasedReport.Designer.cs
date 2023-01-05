namespace TMS.Reporting
{
    partial class AssigneeBasedReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssigneeBasedReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picpdf = new System.Windows.Forms.PictureBox();
            this.picexcel = new System.Windows.Forms.PictureBox();
            this.groupBoxforeTaskBasedReport = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dview = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.cmbassignee = new System.Windows.Forms.ComboBox();
            this.lblassignee = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picpdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picexcel)).BeginInit();
            this.groupBoxforeTaskBasedReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.picpdf);
            this.panel1.Controls.Add(this.picexcel);
            this.panel1.Controls.Add(this.groupBoxforeTaskBasedReport);
            this.panel1.Controls.Add(this.cmbassignee);
            this.panel1.Controls.Add(this.lblassignee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 597);
            this.panel1.TabIndex = 4;
            // 
            // picpdf
            // 
            this.picpdf.Image = ((System.Drawing.Image)(resources.GetObject("picpdf.Image")));
            this.picpdf.Location = new System.Drawing.Point(943, 108);
            this.picpdf.Name = "picpdf";
            this.picpdf.Size = new System.Drawing.Size(37, 33);
            this.picpdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picpdf.TabIndex = 21;
            this.picpdf.TabStop = false;
            this.picpdf.Click += new System.EventHandler(this.picpdf_Click);
            this.picpdf.MouseHover += new System.EventHandler(this.picpdf_MouseHover);
            // 
            // picexcel
            // 
            this.picexcel.Image = ((System.Drawing.Image)(resources.GetObject("picexcel.Image")));
            this.picexcel.Location = new System.Drawing.Point(887, 108);
            this.picexcel.Name = "picexcel";
            this.picexcel.Size = new System.Drawing.Size(37, 33);
            this.picexcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picexcel.TabIndex = 19;
            this.picexcel.TabStop = false;
            this.picexcel.Click += new System.EventHandler(this.pictureBox1_Click);
            this.picexcel.MouseHover += new System.EventHandler(this.picexcel_MouseHover);
            // 
            // groupBoxforeTaskBasedReport
            // 
            this.groupBoxforeTaskBasedReport.BackColor = System.Drawing.Color.White;
            this.groupBoxforeTaskBasedReport.Controls.Add(this.label1);
            this.groupBoxforeTaskBasedReport.Controls.Add(this.dview);
            this.groupBoxforeTaskBasedReport.Controls.Add(this.btnsave);
            this.groupBoxforeTaskBasedReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxforeTaskBasedReport.Location = new System.Drawing.Point(12, 137);
            this.groupBoxforeTaskBasedReport.Name = "groupBoxforeTaskBasedReport";
            this.groupBoxforeTaskBasedReport.Size = new System.Drawing.Size(1023, 448);
            this.groupBoxforeTaskBasedReport.TabIndex = 16;
            this.groupBoxforeTaskBasedReport.TabStop = false;
            this.groupBoxforeTaskBasedReport.Text = "Task Assignee Based Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // dview
            // 
            this.dview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dview.GridColor = System.Drawing.Color.Gray;
            this.dview.Location = new System.Drawing.Point(6, 25);
            this.dview.Name = "dview";
            this.dview.Size = new System.Drawing.Size(1006, 414);
            this.dview.TabIndex = 0;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(952, 521);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(108, 31);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "&Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // cmbassignee
            // 
            this.cmbassignee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbassignee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbassignee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cmbassignee.FormattingEnabled = true;
            this.cmbassignee.Location = new System.Drawing.Point(395, 48);
            this.cmbassignee.Name = "cmbassignee";
            this.cmbassignee.Size = new System.Drawing.Size(296, 29);
            this.cmbassignee.TabIndex = 9;
            this.cmbassignee.SelectedIndexChanged += new System.EventHandler(this.cmbassignee_SelectedIndexChanged);
            // 
            // lblassignee
            // 
            this.lblassignee.AutoSize = true;
            this.lblassignee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblassignee.Location = new System.Drawing.Point(264, 52);
            this.lblassignee.Name = "lblassignee";
            this.lblassignee.Size = new System.Drawing.Size(128, 19);
            this.lblassignee.TabIndex = 8;
            this.lblassignee.Text = "Select Assignee";
            // 
            // AssigneeBasedReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 597);
            this.Controls.Add(this.panel1);
            this.Name = "AssigneeBasedReport";
            this.Text = "Assignee Based Report";
            this.Load += new System.EventHandler(this.AssigneeBasedReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picpdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picexcel)).EndInit();
            this.groupBoxforeTaskBasedReport.ResumeLayout(false);
            this.groupBoxforeTaskBasedReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dview;
        private System.Windows.Forms.ComboBox cmbassignee;
        private System.Windows.Forms.Label lblassignee;
        private System.Windows.Forms.GroupBox groupBoxforeTaskBasedReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.PictureBox picexcel;
        private System.Windows.Forms.PictureBox picpdf;
    }
}