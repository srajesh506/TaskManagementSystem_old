﻿namespace TMS.Home
{
    partial class CreateWorkItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxforexistingemployee = new System.Windows.Forms.GroupBox();
            this.dview = new System.Windows.Forms.DataGridView();
            this.groupBoxforbutton = new System.Windows.Forms.GroupBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnmodify = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.gbxassigntask = new System.Windows.Forms.GroupBox();
            this.cmbsubtask = new System.Windows.Forms.ComboBox();
            this.cmbtask = new System.Windows.Forms.ComboBox();
            this.lbltask = new System.Windows.Forms.Label();
            this.cmbactivity = new System.Windows.Forms.ComboBox();
            this.lblactivity = new System.Windows.Forms.Label();
            this.rtxtremark = new System.Windows.Forms.RichTextBox();
            this.lblsubtaskname = new System.Windows.Forms.Label();
            this.lblsubtaskremark = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxforexistingemployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dview)).BeginInit();
            this.groupBoxforbutton.SuspendLayout();
            this.gbxassigntask.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBoxforexistingemployee);
            this.panel1.Controls.Add(this.groupBoxforbutton);
            this.panel1.Controls.Add(this.gbxassigntask);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 597);
            this.panel1.TabIndex = 4;
            // 
            // groupBoxforexistingemployee
            // 
            this.groupBoxforexistingemployee.BackColor = System.Drawing.Color.White;
            this.groupBoxforexistingemployee.Controls.Add(this.dview);
            this.groupBoxforexistingemployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxforexistingemployee.Location = new System.Drawing.Point(12, 290);
            this.groupBoxforexistingemployee.Name = "groupBoxforexistingemployee";
            this.groupBoxforexistingemployee.Size = new System.Drawing.Size(1076, 289);
            this.groupBoxforexistingemployee.TabIndex = 15;
            this.groupBoxforexistingemployee.TabStop = false;
            this.groupBoxforexistingemployee.Text = "WorkItems";
            // 
            // dview
            // 
            this.dview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dview.GridColor = System.Drawing.Color.Gray;
            this.dview.Location = new System.Drawing.Point(6, 24);
            this.dview.Name = "dview";
            this.dview.Size = new System.Drawing.Size(1054, 248);
            this.dview.TabIndex = 0;
            this.dview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dview_CellClick);
            // 
            // groupBoxforbutton
            // 
            this.groupBoxforbutton.Controls.Add(this.btnsave);
            this.groupBoxforbutton.Controls.Add(this.btnmodify);
            this.groupBoxforbutton.Controls.Add(this.btncancel);
            this.groupBoxforbutton.Controls.Add(this.btnadd);
            this.groupBoxforbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxforbutton.Location = new System.Drawing.Point(403, 236);
            this.groupBoxforbutton.Name = "groupBoxforbutton";
            this.groupBoxforbutton.Size = new System.Drawing.Size(316, 48);
            this.groupBoxforbutton.TabIndex = 14;
            this.groupBoxforbutton.TabStop = false;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(82, 11);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(72, 31);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "&Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnmodify
            // 
            this.btnmodify.Location = new System.Drawing.Point(159, 11);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.Size = new System.Drawing.Size(72, 31);
            this.btnmodify.TabIndex = 15;
            this.btnmodify.Text = "&Modify";
            this.btnmodify.UseVisualStyleBackColor = true;
            this.btnmodify.Click += new System.EventHandler(this.btnmodify_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(237, 11);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(72, 31);
            this.btncancel.TabIndex = 16;
            this.btncancel.Text = "&Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(6, 11);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(72, 31);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "&Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // gbxassigntask
            // 
            this.gbxassigntask.Controls.Add(this.cmbsubtask);
            this.gbxassigntask.Controls.Add(this.cmbtask);
            this.gbxassigntask.Controls.Add(this.lbltask);
            this.gbxassigntask.Controls.Add(this.cmbactivity);
            this.gbxassigntask.Controls.Add(this.lblactivity);
            this.gbxassigntask.Controls.Add(this.rtxtremark);
            this.gbxassigntask.Controls.Add(this.lblsubtaskname);
            this.gbxassigntask.Controls.Add(this.lblsubtaskremark);
            this.gbxassigntask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbxassigntask.Location = new System.Drawing.Point(12, 2);
            this.gbxassigntask.Name = "gbxassigntask";
            this.gbxassigntask.Size = new System.Drawing.Size(1076, 228);
            this.gbxassigntask.TabIndex = 12;
            this.gbxassigntask.TabStop = false;
            this.gbxassigntask.Text = "Create WorkItem";
            // 
            // cmbsubtask
            // 
            this.cmbsubtask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsubtask.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsubtask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cmbsubtask.FormattingEnabled = true;
            this.cmbsubtask.Location = new System.Drawing.Point(478, 96);
            this.cmbsubtask.Name = "cmbsubtask";
            this.cmbsubtask.Size = new System.Drawing.Size(296, 29);
            this.cmbsubtask.TabIndex = 14;
            // 
            // cmbtask
            // 
            this.cmbtask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtask.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cmbtask.FormattingEnabled = true;
            this.cmbtask.Location = new System.Drawing.Point(478, 61);
            this.cmbtask.Name = "cmbtask";
            this.cmbtask.Size = new System.Drawing.Size(296, 29);
            this.cmbtask.TabIndex = 11;
            this.cmbtask.SelectedIndexChanged += new System.EventHandler(this.cmbtask_SelectedIndexChanged);
            // 
            // lbltask
            // 
            this.lbltask.AutoSize = true;
            this.lbltask.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltask.Location = new System.Drawing.Point(315, 61);
            this.lbltask.Name = "lbltask";
            this.lbltask.Size = new System.Drawing.Size(92, 19);
            this.lbltask.TabIndex = 10;
            this.lbltask.Text = "Select Task";
            // 
            // cmbactivity
            // 
            this.cmbactivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbactivity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbactivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cmbactivity.FormattingEnabled = true;
            this.cmbactivity.Location = new System.Drawing.Point(478, 23);
            this.cmbactivity.Name = "cmbactivity";
            this.cmbactivity.Size = new System.Drawing.Size(296, 29);
            this.cmbactivity.TabIndex = 9;
            this.cmbactivity.SelectedIndexChanged += new System.EventHandler(this.cmbactivity_SelectedIndexChanged);
            // 
            // lblactivity
            // 
            this.lblactivity.AutoSize = true;
            this.lblactivity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblactivity.Location = new System.Drawing.Point(315, 23);
            this.lblactivity.Name = "lblactivity";
            this.lblactivity.Size = new System.Drawing.Size(115, 19);
            this.lblactivity.TabIndex = 8;
            this.lblactivity.Text = "Select Activity";
            // 
            // rtxtremark
            // 
            this.rtxtremark.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rtxtremark.Location = new System.Drawing.Point(478, 130);
            this.rtxtremark.Name = "rtxtremark";
            this.rtxtremark.Size = new System.Drawing.Size(296, 62);
            this.rtxtremark.TabIndex = 6;
            this.rtxtremark.Text = "";
            // 
            // lblsubtaskname
            // 
            this.lblsubtaskname.AutoSize = true;
            this.lblsubtaskname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtaskname.Location = new System.Drawing.Point(315, 95);
            this.lblsubtaskname.Name = "lblsubtaskname";
            this.lblsubtaskname.Size = new System.Drawing.Size(121, 19);
            this.lblsubtaskname.TabIndex = 1;
            this.lblsubtaskname.Text = "Select SubTask";
            // 
            // lblsubtaskremark
            // 
            this.lblsubtaskremark.AutoSize = true;
            this.lblsubtaskremark.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblsubtaskremark.Location = new System.Drawing.Point(315, 130);
            this.lblsubtaskremark.Name = "lblsubtaskremark";
            this.lblsubtaskremark.Size = new System.Drawing.Size(94, 19);
            this.lblsubtaskremark.TabIndex = 5;
            this.lblsubtaskremark.Text = "Description";
            // 
            // RemarkAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 597);
            this.Controls.Add(this.panel1);
            this.Name = "RemarkAssignment";
            this.Text = "Create WorkItem";
            this.Load += new System.EventHandler(this.AssignTask_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxforexistingemployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dview)).EndInit();
            this.groupBoxforbutton.ResumeLayout(false);
            this.gbxassigntask.ResumeLayout(false);
            this.gbxassigntask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxforexistingemployee;
        private System.Windows.Forms.DataGridView dview;
        private System.Windows.Forms.GroupBox groupBoxforbutton;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnmodify;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.GroupBox gbxassigntask;
        private System.Windows.Forms.ComboBox cmbtask;
        private System.Windows.Forms.Label lbltask;
        private System.Windows.Forms.ComboBox cmbactivity;
        private System.Windows.Forms.Label lblactivity;
        private System.Windows.Forms.RichTextBox rtxtremark;
        private System.Windows.Forms.Label lblsubtaskname;
        private System.Windows.Forms.Label lblsubtaskremark;
        private System.Windows.Forms.ComboBox cmbsubtask;
    }
}