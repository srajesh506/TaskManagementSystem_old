namespace TMS.Reporting
{
    partial class TimeBasedReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeBasedReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblenddate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.picpdf = new System.Windows.Forms.PictureBox();
            this.picexcel = new System.Windows.Forms.PictureBox();
            this.groupBoxforeTaskBasedReport = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dview = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.lblstartdate = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.lblenddate);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.picpdf);
            this.panel1.Controls.Add(this.picexcel);
            this.panel1.Controls.Add(this.groupBoxforeTaskBasedReport);
            this.panel1.Controls.Add(this.lblstartdate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 639);
            this.panel1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MMM-yy";
            this.dateTimePicker2.Location = new System.Drawing.Point(424, 74);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // lblenddate
            // 
            this.lblenddate.AutoSize = true;
            this.lblenddate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenddate.Location = new System.Drawing.Point(337, 74);
            this.lblenddate.Name = "lblenddate";
            this.lblenddate.Size = new System.Drawing.Size(78, 19);
            this.lblenddate.TabIndex = 23;
            this.lblenddate.Text = "End Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dateTimePicker1.CustomFormat = "dd-MMM-yy";
            this.dateTimePicker1.Location = new System.Drawing.Point(424, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // picpdf
            // 
            this.picpdf.Image = ((System.Drawing.Image)(resources.GetObject("picpdf.Image")));
            this.picpdf.Location = new System.Drawing.Point(964, 88);
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
            this.picexcel.Location = new System.Drawing.Point(908, 88);
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
            this.groupBoxforeTaskBasedReport.Location = new System.Drawing.Point(12, 126);
            this.groupBoxforeTaskBasedReport.Name = "groupBoxforeTaskBasedReport";
            this.groupBoxforeTaskBasedReport.Size = new System.Drawing.Size(1097, 506);
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
            this.dview.Size = new System.Drawing.Size(1083, 472);
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
            // lblstartdate
            // 
            this.lblstartdate.AutoSize = true;
            this.lblstartdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstartdate.Location = new System.Drawing.Point(337, 36);
            this.lblstartdate.Name = "lblstartdate";
            this.lblstartdate.Size = new System.Drawing.Size(81, 19);
            this.lblstartdate.TabIndex = 8;
            this.lblstartdate.Text = "Start Date";
            // 
            // TimeBasedReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1119, 639);
            this.Controls.Add(this.panel1);
            this.Name = "TimeBasedReport";
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
        private System.Windows.Forms.Label lblstartdate;
        private System.Windows.Forms.GroupBox groupBoxforeTaskBasedReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.PictureBox picexcel;
        private System.Windows.Forms.PictureBox picpdf;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblenddate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}