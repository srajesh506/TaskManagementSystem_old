using System.Drawing;
using System.Windows.Forms;

namespace TMS.Home
{
    partial class WorkItemAssignments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxforexistingemployee = new System.Windows.Forms.GroupBox();
            this.chkFilterActive = new System.Windows.Forms.CheckBox();
            this.dview = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBoxforexistingemployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBoxforexistingemployee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 639);
            this.panel1.TabIndex = 4;
            // 
            // groupBoxforexistingemployee
            // 
            this.groupBoxforexistingemployee.BackColor = System.Drawing.Color.White;
            this.groupBoxforexistingemployee.Controls.Add(this.chkFilterActive);
            this.groupBoxforexistingemployee.Controls.Add(this.dview);
            this.groupBoxforexistingemployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxforexistingemployee.Location = new System.Drawing.Point(3, 12);
            this.groupBoxforexistingemployee.Name = "groupBoxforexistingemployee";
            this.groupBoxforexistingemployee.Size = new System.Drawing.Size(1106, 618);
            this.groupBoxforexistingemployee.TabIndex = 15;
            this.groupBoxforexistingemployee.TabStop = false;
            this.groupBoxforexistingemployee.Text = "Assign WorkItems";
            // 
            // chkFilterActive
            // 
            this.chkFilterActive.AutoSize = true;
            this.chkFilterActive.Location = new System.Drawing.Point(689, 14);
            this.chkFilterActive.Name = "chkFilterActive";
            this.chkFilterActive.Size = new System.Drawing.Size(189, 24);
            this.chkFilterActive.TabIndex = 1;
            this.chkFilterActive.Text = "Filter Active Workitems";
            this.chkFilterActive.UseVisualStyleBackColor = true;
            this.chkFilterActive.CheckedChanged += new System.EventHandler(this.chkFilterActive_CheckedChanged);
            // 
            // dview
            // 
            this.dview.AllowUserToAddRows = false;
            this.dview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dview.DefaultCellStyle = dataGridViewCellStyle1;
            this.dview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
            this.dview.Location = new System.Drawing.Point(6, 44);
            this.dview.Name = "dview";
            this.dview.RowTemplate.Height = 30;
            this.dview.Size = new System.Drawing.Size(1091, 565);
            this.dview.TabIndex = 0;
            this.dview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dview_CellClick);
            this.dview.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dview_CellFormatting);
            this.dview.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.savetext);
            this.dview.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dview_RowStateChanged);
            // 
            // WorkItemAssignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 639);
            this.Controls.Add(this.panel1);
            this.Name = "WorkItemAssignments";
            this.Text = "Assign WorkItem";
            this.Load += new System.EventHandler(this.AssignTask_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxforexistingemployee.ResumeLayout(false);
            this.groupBoxforexistingemployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxforexistingemployee;
        private System.Windows.Forms.DataGridView dview;
        private CheckBox chkFilterActive;
    }
}