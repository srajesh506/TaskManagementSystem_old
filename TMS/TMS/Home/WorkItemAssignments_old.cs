using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.Home
{
    public partial class WorkItemAssignments_old : Form
    {
        App_Code.CodeTMS obj = new App_Code.CodeTMS();
        static string activityid;
        static string taskid;
        static string Subtaskid;
        static string id;
        public WorkItemAssignments_old()
        {
            InitializeComponent();
            LoadTheme();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM dd, yyyy";

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
            btnsave.ForeColor = ThemeColor.PrimaryColor;
            //btnmodify.ForeColor = ThemeColor.PrimaryColor;
            //btncancel.ForeColor = ThemeColor.PrimaryColor;
            //groupBoxforbutton.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforexistingemployee.ForeColor = ThemeColor.PrimaryColor;
        }
        private void AssignTask_Load(object sender, EventArgs e)
        {
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
        }
        private void btnadd_Click(object sender, EventArgs e)
        { 
            //enabledisablebuttons(1);
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
           
           
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
                        obj.FireQuery("Delete from tbl_workitemsassignment");
                        string assignmentid = row.Cells["assignmentid"].Value.ToString();
                        string empid = row.Cells["Assigned To"].Value.ToString();
                        string statusid = (row.Cells["Status"].Value.ToString()==null) ? "1" : row.Cells["Status"].Value.ToString();
                        DateTime dt = (Convert.ToDateTime(row.Cells["StartDate"].Value)== Convert.ToDateTime("1 / 1 / 0001 12:00:00 AM")) ? DateTime.Now : Convert.ToDateTime(row.Cells["StartDate"].Value) ;
                        //dateTimePicker1.Value = DateTime.ParseExact(row.Cells["StartDate"].Value.ToString(), "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture); //? DateTime.ParseExact(DateTime.Now.ToString(),"(yyyy, M, d)", CultureInfo.InvariantCulture) : DateTime.ParseExact(row.Cells["StartDate"].Value.ToString(), "(yyyy, M, d)", CultureInfo.InvariantCulture);
                        //string HandOverORClosedDate = (row.Cells["HandOverORClosedDate"].Value.ToString()==null)? DateTime.Now.ToString() : row.Cells["HandOverORClosedDate"].Value.ToString();
                       obj.FireQuery("insert into tbl_workitemsassignment(assigmentitemId,empid,Status,Start_Date)Values('" + assignmentid + "','"+ empid + "','"+ statusid + "','"+ dt.ToString("MM/dd/yyyy") + "')");
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
                // Apply on column index in which you want to display DatetimePicker.
                // For this example it is 2.
                if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
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
                }
            }
        }
        private void DateTimePickerChange(object sender, EventArgs e)
        {
            dview.CurrentCell.Value = dateTimePicker1.Text.ToString();
            //MessageBox.Show(string.Format("Date changed to {0}", dateTimePicker1.Text.ToString()));
        }
        private void DateTimePickerClose(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dview_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
           
        }

       
    }
}
