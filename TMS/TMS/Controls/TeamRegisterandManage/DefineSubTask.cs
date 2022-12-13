using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.Controls.TeamRegisterandManage
{
    public partial class DefineSubTask : UserControl
    {
        App_Code.CodeTMS obj = new App_Code.CodeTMS();
        int activityid;
        static int Subtaskid;
        public DefineSubTask()
        {
            InitializeComponent();
            LoadTheme();
            cmbtask.SelectedText = "--Select Task--";
            GetAllData();
            enabledisablebuttons(2);
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
            //lblsubtaskremark.ForeColor = ThemeColor.SecondaryColor;
            //lblsubtaskname.ForeColor = ThemeColor.SecondaryColor;
            //lblactivity.ForeColor = ThemeColor.SecondaryColor;
            //lbltask.ForeColor = ThemeColor.SecondaryColor;
            gbxtaskmanagement.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforbutton.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforexistingemployee.ForeColor = ThemeColor.PrimaryColor;
            txtsubtaskName.ForeColor = ThemeColor.SecondaryColor;
            rtxtremark.ForeColor = ThemeColor.SecondaryColor;
            chkactive.ForeColor = ThemeColor.SecondaryColor;
            cmbactivity.ForeColor = ThemeColor.SecondaryColor;
            cmbtask.ForeColor = ThemeColor.SecondaryColor;
        }

        private void DefineSubTask_Load(object sender, EventArgs e)
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
                ds_task = obj.GetDataFromTable("Select * from tbl_task where activityid='"+ cmbactivity.SelectedValue +"'");
                DataRow dr_task;
                dr_task = ds_task.Tables[0].NewRow();
                dr_task.ItemArray = new object[] { 0, "--Select Task--" };
                ds_task.Tables[0].Rows.InsertAt(dr_task, 0);
                cmbtask.ValueMember = "taskid";
                cmbtask.DisplayMember = "taskName";
                cmbtask.DataSource = ds_task.Tables[0];
                if (cmbactivity.SelectedIndex > 0)
                {
                    dview.DataSource = null;
                    dview.DataSource = obj.GetDataFromTable("Select ROW_NUMBER()OVER (ORDER BY subtaskid)SLNO,activityname as [Activity Name],taskName as [Task Name],subtaskname as [SubTask Name],Subtaskdescription as [SubTask Description],Isactive,taskid,activityid,Subtaskid from View_SubtaskRelateTaskandActivity where IsActive=1 and activityid='" + cmbactivity.SelectedValue + "'").Tables[0];
                    dview.Columns[0].Width = 50;
                    dview.Columns[1].Width = 200;
                    dview.Columns[2].Width = 300;
                    dview.Columns[3].Width = 300;
                    dview.Columns[4].Width = 400;
                    dview.Columns[5].Visible = false;
                    dview.Columns[6].Visible = false;
                    dview.Columns[7].Visible = false;
                    dview.Columns[8].Visible = false;
                    dview.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                if (txtsubtaskName.Text == "")
                {
                    MessageBox.Show("Please Enter SubTask Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtsubtaskName.Select();
                    return;
                }
                if (rtxtremark.Text == "")
                {
                    MessageBox.Show("Please enter SubTask Description!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rtxtremark.Select();
                    return;
                }
                if (chkactive.Checked == false)
                {
                    MessageBox.Show("Please Confirm Active Activity!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                obj.FireQuery("insert into tbl_subtask(subtaskname,subtaskdescription,activityid,taskid,isactive,Createddate)Values('" + txtsubtaskName.Text + "','" + rtxtremark.Text + "','" + cmbactivity.SelectedValue + "','" + cmbtask.SelectedValue + "','" + chkactive.Checked + "','" + DateTime.Now.ToString("yyyy - MM - dd HH: mm:ss") + "')");
                GetAllData();
                obj.clearControls(gbxtaskmanagement);
                enabledisablebuttons(2);
                MessageBox.Show("Data Saved Successfully!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                txtsubtaskName.Enabled = true;
                txtsubtaskName.Enabled = true;
                txtsubtaskName.Select();
                btnsave.Enabled = true;
                btncancel.Enabled = true;
                rtxtremark.Enabled = true;
                btnadd.Enabled = false;
                cmbactivity.Enabled = true;
                cmbtask.Enabled = true;
            }
            if (flag == 2)//modify and Cancel
            {
                txtsubtaskName.Enabled = false;
                rtxtremark.Enabled = false;
                btnsave.Enabled = false;
                btncancel.Enabled = false;
                btnmodify.Enabled = false;
                btnadd.Enabled = true;
                cmbactivity.Enabled = false;
                cmbtask.Enabled = false;
            }
            if (flag == 3)
            {
                txtsubtaskName.Enabled = true;
                rtxtremark.Enabled = true;
                btnadd.Enabled = false;
                btnsave.Enabled = false;
                btncancel.Enabled = true;
                btnmodify.Enabled = true;
                cmbactivity.Enabled = true;
                cmbtask.Enabled = true;
            }
        }

        public void GetAllData()
        {
            dview.DataSource = null;
            dview.DataSource = obj.GetDataFromTable("Select ROW_NUMBER()OVER (ORDER BY subtaskid)SLNO,activityname as [Activity Name],taskName as [Task Name],subtaskname as [SubTask Name],Subtaskdescription as [SubTask Description],Isactive,taskid,activityid,Subtaskid from View_SubtaskRelateTaskandActivity where IsActive=1").Tables[0];
            dview.Columns[0].Width = 50;
            dview.Columns[1].Width = 200;
            dview.Columns[2].Width = 300;
            dview.Columns[3].Width = 300;
            dview.Columns[4].Width = 400;
            dview.Columns[5].Visible = false;
            dview.Columns[6].Visible = false;
            dview.Columns[7].Visible = false;
            dview.Columns[8].Visible = false;
            dview.ReadOnly = true;

        }

        private void dview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Subtaskid = 0;
                int index = dview.CurrentRow.Index;
                if (index <= dview.RowCount - 1)
                {
                    activityid = Convert.ToInt32(dview.Rows[index].Cells[7].Value);
                    cmbactivity.SelectedValue = Convert.ToString(dview.Rows[index].Cells[7].Value);
                    cmbtask.SelectedValue = Convert.ToString(dview.Rows[index].Cells[6].Value);
                    txtsubtaskName.Text = Convert.ToString(dview.Rows[index].Cells[3].Value);
                    rtxtremark.Text = Convert.ToString(dview.Rows[index].Cells[4].Value);
                    chkactive.Checked = Convert.ToBoolean(dview.Rows[index].Cells[5].Value);
                    Subtaskid = Convert.ToInt32(dview.Rows[index].Cells[8].Value);
                    enabledisablebuttons(3);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            obj.clearControls(gbxtaskmanagement);
            enabledisablebuttons(2);
            GetAllData();
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
                if (txtsubtaskName.Text == "")
                {
                    MessageBox.Show("Please Enter SubTask Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtsubtaskName.Select();
                    return;
                }
                if (rtxtremark.Text == "")
                {
                    MessageBox.Show("Please enter SubTask Description!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rtxtremark.Select();
                    return;
                }
                obj.FireQuery("Update tbl_subtask Set subtaskname='" + txtsubtaskName.Text + "',Subtaskdescription='" + rtxtremark.Text + "',activityid='" + cmbactivity.SelectedValue + "',taskid='" + cmbtask.SelectedValue + "',Modifydate='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',Isactive='" + chkactive.Checked + "' where subtaskid='" + Subtaskid + "'");
                obj.clearControls(gbxtaskmanagement);
                GetAllData();
                enabledisablebuttons(2);
                MessageBox.Show("Data modify Successfully!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            enabledisablebuttons(1);
        }

        private void cmbtask_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbactivity.SelectedIndex > 0 && cmbtask.SelectedIndex > 0)
                {
                    dview.DataSource = null;
                    dview.DataSource = obj.GetDataFromTable("Select ROW_NUMBER()OVER (ORDER BY subtaskid)SLNO,activityname as [Activity Name],taskName as [Task Name],subtaskname as [SubTask Name],Subtaskdescription as [SubTask Description],Isactive,taskid,activityid,Subtaskid from View_SubtaskRelateTaskandActivity where IsActive=1 and activityid='" + cmbactivity.SelectedValue + "' and taskid='" + cmbtask.SelectedValue + "'").Tables[0];
                    dview.Columns[0].Width = 50;
                    dview.Columns[1].Width = 200;
                    dview.Columns[2].Width = 300;
                    dview.Columns[3].Width = 300;
                    dview.Columns[4].Width = 400;
                    dview.Columns[5].Visible = false;
                    dview.Columns[6].Visible = false;
                    dview.Columns[7].Visible = false;
                    dview.Columns[8].Visible = false;
                    dview.ReadOnly = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
