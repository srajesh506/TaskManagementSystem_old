using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static ;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TMS.Home
{
    public partial class WorkItemAssignments : Form
    {
        App_Code.CodeTMS obj = new App_Code.CodeTMS();
        static int id;
        static int workitemid;
        static int status;
        static int empid;
        static string empname;
        static string remarks;
        static int modifiedcolumn;


        public WorkItemAssignments()
        {
            InitializeComponent();
            LoadTheme();
            GetAllData();
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "MM dd, yyyy";

        }
        //public void enabledisablebuttons(int flag)
        //{
        //    if (flag == 0) //
        //    {
        //        btnsave.Enabled = false;
        //        btnmodify.Enabled = false;
        //        btncancel.Enabled = false;
        //    }
        //    if (flag == 1) //Add Data
        //    {
        //        btnsave.Enabled = true;
        //        btncancel.Enabled = true;
        //        btnadd.Enabled = false;

        //    }
        //    if (flag == 2)//modify and Cancel
        //    {
        //        btnsave.Enabled = false;
        //        btncancel.Enabled = false;
        //        btnmodify.Enabled = false;
        //        btnadd.Enabled = true;
        //    }
        //    if (flag == 3)
        //    {
        //        btnadd.Enabled = false;
        //        btnsave.Enabled = false;
        //        btncancel.Enabled = true;
        //        btnmodify.Enabled = true;
        //    }
        //}
        private void LoadTheme()
        {

            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            //btnadd.ForeColor = ThemeColor.PrimaryColor;
            //btnsave.ForeColor = ThemeColor.PrimaryColor;
            //btnmodify.ForeColor = ThemeColor.PrimaryColor;
            //btncancel.ForeColor = ThemeColor.PrimaryColor;
            //groupBoxforbutton.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforexistingemployee.ForeColor = ThemeColor.PrimaryColor;
        }

        private void dview_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dview.Rows.Count; i++)
            {
                if (dview.Rows[i].Cells[3].Value.ToString() == "Completed")
                {
                    dview.Rows[i].DefaultCellStyle.BackColor = Color.Lavender;
                    dview.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
                }
                else if (dview.Rows[i].Cells[3].Value.ToString() == "HandedOver")
                {
                    dview.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;
                    dview.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
                }
                else if (dview.Rows[i].Cells[3].Value.ToString() == "Pending")
                {
                    dview.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dview.Rows[i].DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                }
                else if (dview.Rows[i].Cells[3].Value.ToString() == "InProgress" || dview.Rows[i].Cells[3].Value.ToString() == "Monitoring")
                {
                    dview.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    dview.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
                }
                else
                {
                    dview.Rows[i].DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
                    dview.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
                }

            }

        }

        public void GetAllData(bool filterflag=false)
        {
            dview.DataSource = null;
            //dview.DataSource = obj.GetDataFromTable("SELECT dbo.tbl_workitemsassignment.Id as Id, dbo.tbl_workitemsassignment.assigmentitemId as WorkItemId, dbo.tbl_workitems.Remark as WorkItem, FORMAT(dbo.tbl_workitemsassignment.Start_Date, 'dd-MMM-yy') AS StartDate, dbo.tbl_workitemsassignment.[HandOver/ClosedDate] as ClosedDate, ISNULL(dbo.tbl_status.Status,'--Choose--')  as Status, ISNULL(dbo.UserMaster.EmpName,'--Choose--')  as Employee FROM dbo.tbl_workitemsassignment INNER JOIN dbo.tbl_workitems ON dbo.tbl_workitemsassignment.assigmentitemId = dbo.tbl_workitems.Id INNER JOIN dbo.tbl_status ON dbo.tbl_workitemsassignment.Status = dbo.tbl_status.StatusId LEFT OUTER JOIN dbo.UserMaster ON dbo.tbl_workitemsassignment.empid = dbo.UserMaster.empid").Tables[0];

            if (filterflag)
            {
                dview.DataSource = obj.getworkassignmentitems(true).Tables[0];
            }
            else
            { 
                dview.DataSource = obj.getworkassignmentitems().Tables[0];
            }


            dview.Columns[0].Visible = false;               //Id
            dview.Columns[1].Visible = false;               //WorkItemID
            dview.Columns[2].Width = 175;                   //WorkItemDescription
            dview.Columns[3].Width = 90;                    //Status
            dview.Columns[4].Width = 100;                   //AssignedTo
            dview.Columns[5].Width = 150;                   //StartDate
            dview.Columns[6].Width = 150;                   //ClosedDate
            dview.Columns[7].Width = 105;                   //HandedOverTo
            dview.Columns[8].Width = 300;                   //Remarks

            dview.Columns[2].ReadOnly = true;
            dview.Columns[3].ReadOnly = true;
            dview.Columns[4].ReadOnly = true;
            dview.Columns[5].ReadOnly = true;
            dview.Columns[6].ReadOnly = true;
            dview.Columns[7].ReadOnly = true;
            dview.Columns[8].ReadOnly = true;
        }

        private void AssignTask_Load(object sender, EventArgs e)
        {

            /*
            try
            {

                DataSet ds_WorkItems = new DataSet();
                DataSet ds_EmpName = new DataSet();
                DataSet ds_Status = new DataSet();
                DataTable table = new DataTable();
                table.Columns.Add("assignmentid", typeof(int));
                table.Columns.Add("Work Item Description", typeof(string));
                ds_WorkItems = obj.GetDataFromTable("Select Id,Remark from tbl_workitems");
                ds_EmpName = obj.GetDataFromTable("Select empid,EmpName from UserMaster where IsActive=1");
                ds_Status = obj.GetDataFromTable("Select Statusid,Status from tbl_status");
                if (ds_WorkItems.Tables[0].Rows.Count>0)
                {
                    for(int i=0; i<=ds_WorkItems.Tables[0].Rows.Count-1; i++)
                    {

                        DataRow dr = table.NewRow();
                        dr["assignmentid"] = ds_WorkItems.Tables[0].Rows[i]["Id"].ToString();
                        dr["Work Item Description"] = ds_WorkItems.Tables[0].Rows[i]["Remark"].ToString();
                        table.Rows.Add(dr);
                        dview.DataSource = table;
                    }
                    DataGridViewComboBoxColumn coloumn_empname = new DataGridViewComboBoxColumn();
                    coloumn_empname.HeaderText = "Assigned To";
                    coloumn_empname.Name= "Assigned To";
                    DataRow dr_empname;
                    dr_empname = ds_EmpName.Tables[0].NewRow();
                    dr_empname.ItemArray = new object[] { 0, "--please Select--" };
                    ds_EmpName.Tables[0].Rows.InsertAt(dr_empname, 0);
                    coloumn_empname.DataSource = ds_EmpName.Tables[0];
                    coloumn_empname.ValueMember = "empid";
                    coloumn_empname.DisplayMember = "EmpName";
                    dview.Columns.Add(coloumn_empname);
                    

                    DataGridViewComboBoxColumn coloumn_Status = new DataGridViewComboBoxColumn();
                    coloumn_Status.HeaderText = "Status";
                    coloumn_Status.Name = "Status";
                    DataRow dr_status;
                    dr_status = ds_Status.Tables[0].NewRow();
                    dr_status.ItemArray = new object[] { 0, "--please Select--" };
                    ds_Status.Tables[0].Rows.InsertAt(dr_status, 0);
                    coloumn_Status.DataSource = ds_Status.Tables[0];
                    coloumn_Status.ValueMember = "Statusid";
                    coloumn_Status.DisplayMember = "Status";
                    dview.Columns.Add(coloumn_Status);
                    dview.Columns.Add("StartDate", "StartDate");
                    dview.Columns.Add("HandOverORClosedDate", "HandOver/ClosedDate");
                    dview.Columns[0].Width = 50;
                    dview.Columns[0].Visible = false;
                    dview.Columns[1].Width = 200;
                    dview.Columns[1].ReadOnly = true;
                    dview.Columns[2].Width = 200;
                    
                    dview.Columns[3].Width = 200;
                    dview.Columns[4].Width = 230;
                    dview.Columns[5].Width = 230;

                  

                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {

                if (dview.Rows.Count > 0)
                {
                    //for(int i=0;i<=dview.Rows.Count-1; i++)
                    //{
                    //    string assignmentid = dview.Rows[i].Cells["assignmentid"].ToString();
                    //    string empid= dview.Rows[i].Cells["empid"].Value.ToString();
                    //    string status = dview.Rows[i].Cells["Statusid"].Value.ToString();
                    //}
                    foreach (DataGridViewRow row in dview.Rows)
                    {

                        string assignmentid = row.Cells["assignmentid"].Value.ToString();
                        string empid = row.Cells["Assigned To"].Value.ToString();
                        string statusid = (row.Cells["Status"].Value.ToString() == null) ? "1" : row.Cells["Status"].Value.ToString();
                        DateTime dt = (Convert.ToDateTime(row.Cells["StartDate"].Value) == Convert.ToDateTime("1 / 1 / 0001 12:00:00 AM")) ? DateTime.Now : Convert.ToDateTime(row.Cells["StartDate"].Value);
                        //dateTimePicker1.Value = DateTime.ParseExact(row.Cells["StartDate"].Value.ToString(), "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture); //? DateTime.ParseExact(DateTime.Now.ToString(),"(yyyy, M, d)", CultureInfo.InvariantCulture) : DateTime.ParseExact(row.Cells["StartDate"].Value.ToString(), "(yyyy, M, d)", CultureInfo.InvariantCulture);
                        //string HandOverORClosedDate = (row.Cells["HandOverORClosedDate"].Value.ToString()==null)? DateTime.Now.ToString() : row.Cells["HandOverORClosedDate"].Value.ToString();
                        obj.FireQuery("insert into tbl_workitemsassignment(assigmentitemId,empid,Status,Start_Date)Values('" + assignmentid + "','" + empid + "','" + statusid + "','" + dt.ToString("MM/dd/yyyy") + "')");
                    }
                    MessageBox.Show("Data Saved Successfully!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check the cell clicked is not the column header cell
            if (e.RowIndex != -1)
            {
                dview.Controls.Clear();
                if (dview.CurrentRow.Cells[3].Value.ToString() != "Completed" && dview.CurrentRow.Cells[3].Value.ToString() != "HandedOver")
                {
                    int index = dview.CurrentRow.Index;
                    if (index <= dview.RowCount - 1)
                    {
                        id = (int)dview.Rows[index].Cells[0].Value;
                        empname = dview.Rows[index].Cells[4].Value.ToString();
                        workitemid = (int)dview.Rows[index].Cells[1].Value;
                        modifiedcolumn = (int)e.ColumnIndex;
                    }
                    // Apply on column index in which you want to display DatetimePicker.
                    // For this example it is 2.
                    /*
                    if (e.ColumnIndex == 3 || e.ColumnIndex == 4)
                    {
                        // Initialize the dateTimePicker1.
                        dateTimePicker1 = new DateTimePicker();
                        // Adding the dateTimePicker1 into DataGridView.   
                        dview.Controls.Add(dateTimePicker1);
                        // Setting the format i.e. mm/dd/yyyy)
                        dateTimePicker1.Format = DateTimePickerFormat.Short;
                        // Create retangular area that represents the display area for a cell
                        Rectangle oRectangle = dview.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        // Setting area for dateTimePicker1.
                        dateTimePicker1.Size = new Size(oRectangle.Width, oRectangle.Height);
                        // Setting location for dateTimePicker1.
                        dateTimePicker1.Location = new Point(oRectangle.X, oRectangle.Y);
                        // An event attached to dateTimePicker1 which is fired when any date is selected.
                        dateTimePicker1.TextChanged += new EventHandler(DateTimePickerChange);
                        // An event attached to dateTimePicker1 which is fired when DateTimeControl is closed.
                        dateTimePicker1.CloseUp += new EventHandler(DateTimePickerClose);
                    }*/
                    if (e.ColumnIndex == 8)
                    {
                        dview.CurrentCell.ReadOnly = false;
                        remarks = dview.CurrentCell.Value.ToString();
                    }
                    if (e.ColumnIndex == 4)
                    {
                        dview.CurrentCell.ReadOnly = false;
                        DataSet ds_EmpName = new DataSet();
                        ds_EmpName = obj.GetDataFromTable("Select empid, EmpName from UserMaster where IsActive=1");
                        DataRow dr_EmpNameNoValues;
                        dr_EmpNameNoValues = ds_EmpName.Tables[0].NewRow();
                        dr_EmpNameNoValues.ItemArray = new object[] { 0, "--Choose--" };
                        ds_EmpName.Tables[0].Rows.InsertAt(dr_EmpNameNoValues, 0);
                        ComboBox empnamecombo = new ComboBox();
                        empnamecombo.DataSource = ds_EmpName.Tables[0];
                        empnamecombo.ValueMember = "empid";
                        empnamecombo.DisplayMember = "EmpName";
                        empnamecombo.Hide();
                        dview.Controls.Add(empnamecombo);
                        Rectangle oRectangle = dview.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        empnamecombo.Size = new Size(oRectangle.Width, oRectangle.Height);
                        empnamecombo.Location = new Point(oRectangle.X, oRectangle.Y);
                        empnamecombo.SelectedIndexChanged += new EventHandler(comboSelectedIndexChanged);
                        empnamecombo.Leave += new EventHandler(comboLeave);
                        empnamecombo.Show();
                        empnamecombo.SelectedIndex = empnamecombo.FindString(dview.CurrentCell.Value.ToString());
                    }
                    if (e.ColumnIndex == 3)
                    {
                        if (dview.CurrentRow.Cells[4].Value.ToString() != "--Choose--")
                        {
                            dview.CurrentCell.ReadOnly = false;
                            DataSet ds_status = new DataSet();
                            ds_status = obj.GetDataFromTable("Select Statusid,Status from tbl_status where Statusid <> 6");
                            DataRow dr_statusNoValues;
                            dr_statusNoValues = ds_status.Tables[0].NewRow();
                            dr_statusNoValues.ItemArray = new object[] { 0, "--Choose--" };
                            ds_status.Tables[0].Rows.InsertAt(dr_statusNoValues, 0);
                            ComboBox statuscombo = new ComboBox();
                            statuscombo.DataSource = ds_status.Tables[0];
                            statuscombo.ValueMember = "Statusid";
                            statuscombo.DisplayMember = "Status";
                            statuscombo.Hide();
                            dview.Controls.Add(statuscombo);
                            Rectangle oRectangle = dview.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                            statuscombo.Size = new Size(oRectangle.Width, oRectangle.Height);
                            statuscombo.Location = new Point(oRectangle.X, oRectangle.Y);
                            statuscombo.SelectedIndexChanged += new EventHandler(comboSelectedIndexChanged);
                            statuscombo.Leave += new EventHandler(comboLeave);
                            statuscombo.Show();
                            statuscombo.SelectedIndex = statuscombo.FindString(dview.CurrentCell.Value.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Please assign the Work Item to one of the team members first", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }

                }
                else
                {
                    MessageBox.Show("WorkItem is already closed or handed over. Please choose other workitems", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void comboSelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBox temp = (ComboBox) sender;
            ////dview.CurrentCell.Value = temp.GetItemText(temp.SelectedItem);
            //if (modifiedcolumn == 5)    // status
            //{
            //    status = Convert.ToInt32(temp.SelectedValue);
            //}
            //else if (modifiedcolumn == 6) // empId
            //{             
            //    empid = Convert.ToInt32(temp.SelectedValue);
            //}
            //obj.addworkassignmentitem(id, workitemid, empid, status);
            //GetAllData();
        }

        private void savetext(object sender, EventArgs e)
        {
            //dview.CurrentCell.Value = e.;
            if (modifiedcolumn == 8)    // status
            {
                if (remarks != dview.CurrentCell.Value.ToString())
                {
                    obj.addworkassignmentitem(id, workitemid, 0, 0, dview.CurrentCell.Value.ToString());
                }
            }
            if (chkFilterActive.Checked)
            {
                GetAllData(true);
            }
            else
            {
                GetAllData();
            }
            ///temp.Visible = false;
        }

        private void comboLeave(object sender, EventArgs e)
        {
            ComboBox temp = (ComboBox)sender;
            //dview.CurrentCell.Value = temp.GetItemText(temp.SelectedItem);
            if (modifiedcolumn == 3)    // status
            {
                status = Convert.ToInt32(temp.SelectedValue);
                obj.addworkassignmentitem(id, workitemid, 0, status,"");
            }
            else if (modifiedcolumn == 4) // empId
            {
                if (empname != temp.Text)
                {
                    empid = Convert.ToInt32(temp.SelectedValue);
                    obj.addworkassignmentitem(id, workitemid, empid, 0,"");
                }
                else
                {
                    MessageBox.Show("Assigned To Value has not changed. Please choose a different value than currently assigned", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (chkFilterActive.Checked)
            {
                GetAllData(true);
            }
            else
            {
                GetAllData();
            }
            temp.Visible = false;
        }
        private void dview_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "Row", e.Row);
        }

        private void chkFilterActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFilterActive.Checked)
            {
                GetAllData(true);
            }
            else
            {
                GetAllData();
            }
        }

    }
}
