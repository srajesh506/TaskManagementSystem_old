using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.Home
{
    public partial class CreateWorkItem : Form
    {
        App_Code.CodeTMS obj = new App_Code.CodeTMS();
        static string activityid;
        static string taskid;
        static string Subtaskid;
        static string id;
        public CreateWorkItem()
        {
            InitializeComponent();
            LoadTheme();
            cmbtask.SelectedText = "--Select Task--";
            getSubtaskDefault();
            GetAllData();
            enabledisablebuttons(2);
            //GetallEmployee();
           
        }
        public void enabledisablebuttons(int flag)
        {
            if (flag == 0) //
            {
                btnsave.Enabled = false;
                btnmodify.Enabled = false;
                btncancel.Enabled = false;
            }
            if (flag == 1) //Add Data
            {
                
                btnsave.Enabled = true;
                btncancel.Enabled = true;
                rtxtremark.Enabled = true;
                btnadd.Enabled = false;
                cmbactivity.Enabled = true;
                cmbtask.Enabled = true;
                cmbsubtask.Enabled = true;
            }
            if (flag == 2)//modify and Cancel
            {
               
                rtxtremark.Enabled = false;
                btnsave.Enabled = false;
                btncancel.Enabled = false;
                btnmodify.Enabled = false;
                btnadd.Enabled = true;
                cmbactivity.Enabled = false;
                cmbtask.Enabled = false;
                cmbsubtask.Enabled = false;
                //for (int i = 0; i < listemp.Items.Count; i++)
                //{
                //        listemp.SetItemChecked(i, false);
                //}
            }
            if (flag == 3)
            {
                rtxtremark.Enabled = true;
                btnadd.Enabled = false;
                btnsave.Enabled = false;
                btncancel.Enabled = true;
                btnmodify.Enabled = true;
                cmbactivity.Enabled = true;
                cmbtask.Enabled = true;
                cmbsubtask.Enabled = true;
            }
        }
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
            btnadd.ForeColor = ThemeColor.PrimaryColor;
            btnsave.ForeColor = ThemeColor.PrimaryColor;
            btnmodify.ForeColor = ThemeColor.PrimaryColor;
            btncancel.ForeColor = ThemeColor.PrimaryColor;
            gbxassigntask.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforbutton.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforexistingemployee.ForeColor = ThemeColor.PrimaryColor;
            rtxtremark.ForeColor = ThemeColor.SecondaryColor;
            cmbactivity.ForeColor = ThemeColor.SecondaryColor;
            cmbtask.ForeColor = ThemeColor.SecondaryColor;
        }
        private void AssignTask_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = obj.GetDataFromTable("Select * from tbl_activity");
                DataRow dr;
                dr = ds.Tables[0].NewRow();
                dr.ItemArray = new object[] { 0, "--Select Activity--" };
                ds.Tables[0].Rows.InsertAt(dr, 0);
                cmbactivity.ValueMember = "activityid";
                cmbactivity.DisplayMember = "activityName";
                cmbactivity.DataSource = ds.Tables[0];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbactivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet ds_task = new DataSet();
                ds_task = obj.GetDataFromTable("Select * from tbl_task where activityid='" + cmbactivity.SelectedValue + "'");
                    DataRow dr_task;
                    dr_task = ds_task.Tables[0].NewRow();
                    dr_task.ItemArray = new object[] { 0, "--Select Task--" };
                    ds_task.Tables[0].Rows.InsertAt(dr_task, 0);
                    cmbtask.ValueMember = "taskid";
                    cmbtask.DisplayMember = "taskName";
                    cmbtask.DataSource = ds_task.Tables[0];
                //if (cmbactivity.SelectedIndex > 0)
                //{
                //    dview.DataSource = null;
                //    dview.DataSource = obj.GetDataFromTable("Select ROW_NUMBER()OVER (ORDER BY subtaskid)SLNO,activityname as [Activity Name],taskName as [Task Name],subtaskname as [SubTask Name],Subtaskdescription as [SubTask Description],Isactive,taskid,activityid,Subtaskid from View_SubtaskRelateTaskandActivity where IsActive=1 and activityid='" + cmbactivity.SelectedValue + "'").Tables[0];
                //    dview.Columns[0].Width = 50;
                //    dview.Columns[1].Width = 200;
                //    dview.Columns[2].Width = 300;
                //    dview.Columns[3].Width = 300;
                //    dview.Columns[4].Width = 400;
                //    dview.Columns[5].Visible = false;
                //    dview.Columns[6].Visible = false;
                //    dview.Columns[7].Visible = false;
                //    dview.Columns[8].Visible = false;
                //    dview.ReadOnly = true;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbtask_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               
                if (cmbtask.SelectedIndex > 0)
                {
                    DataSet ds_SubTask = new DataSet();
                    ds_SubTask = obj.GetDataFromTable("Select Subtaskid,SubtaskName from View_SubtaskRelateTaskandActivity where activityid='" + cmbactivity.SelectedValue + "' and Taskid='"+ cmbtask.SelectedValue +"'");
                    if(ds_SubTask.Tables[0].Rows.Count>0)
                    {
                        cmbsubtask.Enabled = true;
                        DataRow dr_Subtask;
                        dr_Subtask = ds_SubTask.Tables[0].NewRow();
                        dr_Subtask.ItemArray = new object[] { 0, "--Select SubTask--" };
                        ds_SubTask.Tables[0].Rows.InsertAt(dr_Subtask, 0);
                        cmbsubtask.ValueMember = "Subtaskid";
                        cmbsubtask.DisplayMember = "SubtaskName";
                        cmbsubtask.DataSource = ds_SubTask.Tables[0];
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            enabledisablebuttons(1);
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbactivity.SelectedIndex == 0)
                {
                    MessageBox.Show("Please Select Activity Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cmbtask.SelectedIndex == 0)
                {
                    MessageBox.Show("Please Select Task Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cmbsubtask.SelectedIndex == 0)
                {
                    MessageBox.Show("Please Select SubTask Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (rtxtremark.Text == "")
                {
                    MessageBox.Show("Please enter Description!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rtxtremark.Select();
                    return;
                }
                //DataTable dt = new DataTable();
                //dt = obj.GetDataFromTable("Select * from View_AssignTask where activityid='" + cmbactivity.SelectedValue + "' and Empid='"+ Getempid + "' and taskid='"+ cmbtask.SelectedValue + "' and subtaskid='"+ cmbsubtask.SelectedValue + "' and StatusId='6'").Tables[0];
                //if (dt.Rows.Count <= 0)
                //{
                    //foreach (object itemChecked in listemp.CheckedItems)
                    //{
                    //    DataRowView castedItem = itemChecked as DataRowView;
                    //    string EmpName = Convert.ToString(castedItem["EmpName"]);
                    //    int? empid = Convert.ToInt32(castedItem["empID"]);
                    //    dt = obj.GetDataFromTable("Select * from View_AssignTask where activityid='" + cmbactivity.SelectedValue + "' and Empid='" + empid + "' and taskid='" + cmbtask.SelectedValue + "' and subtaskid='" + cmbsubtask.SelectedValue + "' and StatusId='6'").Tables[0];
                    //    if (dt.Rows.Count <= 0)
                    //    {
                            obj.FireQuery("update tbl_workitems Set activityid='" + cmbactivity.SelectedValue + "',taskid='" + cmbtask.SelectedValue + "',subtaskid='" + cmbsubtask.SelectedValue + "',Remark='" + rtxtremark.Text + "' where Id='"+ id +"' ");
                //}else
                //{
                //    MessageBox.Show("Data already exists!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //}

                obj.clearControls(gbxassigntask);
                GetAllData();
                enabledisablebuttons(2);
                MessageBox.Show("Data modify Successfully!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            obj.clearControls(gbxassigntask);
            enabledisablebuttons(2);
            GetAllData();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbactivity.SelectedIndex == 0)
                {
                    MessageBox.Show("Please Select Activity Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cmbtask.SelectedIndex == 0)
                {
                    MessageBox.Show("Please Select Task Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cmbsubtask.SelectedIndex == 0)
                {
                    MessageBox.Show("Please Select SubTask Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (rtxtremark.Text == "")
                {
                    MessageBox.Show("Please enter Remark!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rtxtremark.Select();
                    return;
                }
                //foreach (object itemChecked in listemp.CheckedItems)
                //{
                //    DataRowView castedItem = itemChecked as DataRowView;
                //    string EmpName = Convert.ToString(castedItem["EmpName"]);
                //    int? empid = Convert.ToInt32(castedItem["empID"]);
                //obj.FireQuery("insert into tbl_workitems(activityid,taskid,subtaskid,Remark)Values('" + cmbactivity.SelectedValue + "','" + cmbtask.SelectedValue + "','" + cmbsubtask.SelectedValue + "','"+ rtxtremark.Text +"')");
                //}
                int actityid = (int)cmbactivity.SelectedValue;
                int taskid = (int)cmbtask.SelectedValue;
                int subtaskid = (int)cmbsubtask.SelectedValue;
                string remark = rtxtremark.Text;
                obj.addworkitem(actityid, taskid, subtaskid, remark);
                GetAllData();
                obj.clearControls(gbxassigntask);
                enabledisablebuttons(2);
                MessageBox.Show("Data Saved Successfully!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dview.CurrentRow.Index;
                if (index <= dview.RowCount - 1)
                {
                    activityid = Convert.ToString(dview.Rows[index].Cells[6].Value);
                    taskid = Convert.ToString(dview.Rows[index].Cells[5].Value);
                    Subtaskid = Convert.ToString(dview.Rows[index].Cells[7].Value);
                    id = Convert.ToString(dview.Rows[index].Cells[8].Value);
                    cmbactivity.SelectedValue= Convert.ToString(dview.Rows[index].Cells[6].Value);
                    cmbtask.SelectedValue= Convert.ToString(dview.Rows[index].Cells[5].Value);
                    cmbsubtask.SelectedValue= Convert.ToString(dview.Rows[index].Cells[7].Value);
                    rtxtremark.Text = Convert.ToString(dview.Rows[index].Cells[4].Value);
                    //for (int i = 0; i < listemp.Items.Count; i++)
                    //{
                    //    if (Getempid == ((DataRowView)listemp.Items[i])[1].ToString())
                    //    {
                    //        listemp.SetItemChecked(i, true);
                    //    }
                    //    else
                    //    {
                    //        listemp.SetItemChecked(i, false);
                    //    }
                    //}
                    enabledisablebuttons(3);

                }
           }
            catch(Exception ex)
            {

            }
        }
        //public void GetallEmployee()
        //{
        //    try
        //    {
        //        listemp.DataSource = null;
        //        listemp.DataSource = obj.GetDataFromTable("Select EmpName,empid,isactive from UserMaster where IsActive=1").Tables[0];
        //        listemp.ValueMember = "empid";
        //        listemp.DisplayMember = "EmpName";
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void cmbsubtask_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (cmbsubtask.SelectedIndex > 0)
        //        {
        //            DataSet ds_task = new DataSet();
        //            ds_task = obj.GetDataFromTable("Select SubtaskName from View_SubtaskRelateTaskandActivity where activityid='" + cmbactivity.SelectedValue + "' and Taskid='" + cmbtask.SelectedValue + "'");
        //            rtxtremark.Text = ds_task.Tables[0].Rows[0]["SubtaskName"].ToString();
        //        }
        //        else
        //        {
        //            rtxtremark.Text = "";
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        public void getSubtaskDefault()
        {
            DataTable Dt = new DataTable();
            Dt.Columns.Add(new DataColumn("Subtaskid", typeof(int)));
            Dt.Columns.Add(new DataColumn("SubtaskName", typeof(string)));
            DataRow dr = Dt.NewRow();
            dr = Dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select SubTask--" };
            Dt.Rows.InsertAt(dr, 0);
            cmbsubtask.ValueMember = "Subtaskid";
            cmbsubtask.DisplayMember = "SubtaskName";
            cmbsubtask.DataSource = Dt;
        }
        public void GetAllData()
        {
            dview.DataSource = null;
            dview.DataSource = obj.GetDataFromTable("Select ROW_NUMBER()OVER (ORDER BY Id)SLNO,activityname as [Activity Name],taskName as [Task Name],subtaskname as [SubTask Name],Remark,Taskid,activityid,Subtaskid,id from View_workitems where IsActive=1").Tables[0];
            dview.Columns[0].Width = 70;
            dview.Columns[1].Width = 150;
            dview.Columns[2].Width = 300;
            dview.Columns[3].Width = 200;
            dview.Columns[4].Width = 300;
            dview.Columns[5].Visible = false;
            dview.Columns[6].Visible = false;
            dview.Columns[7].Visible = false;
            dview.Columns[8].Visible = false;
            dview.ReadOnly = true;

        }
    }
}
