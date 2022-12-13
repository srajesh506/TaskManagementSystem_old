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
    public partial class DefineTask : UserControl
    {
        App_Code.CodeTMS obj = new App_Code.CodeTMS();
        static int taskid;
        int activityid;
        public DefineTask()
        {
            InitializeComponent();
            LoadTheme();
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
            gbxtaskmanagement.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforbutton.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforexistingemployee.ForeColor = ThemeColor.PrimaryColor;
            txttaskName.ForeColor = ThemeColor.SecondaryColor;
            rtxtremark.ForeColor = ThemeColor.SecondaryColor;
            chkactive.ForeColor = ThemeColor.SecondaryColor;
            cmbactivity.ForeColor = ThemeColor.SecondaryColor;
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
                txttaskName.Enabled = true;
                txttaskName.Enabled = true;
                txttaskName.Select();
                btnsave.Enabled = true;
                btncancel.Enabled = true;
                rtxtremark.Enabled = true;
                btnadd.Enabled = false;
                cmbactivity.Enabled = true;
            }
            if (flag == 2)//modify and Cancel
            {
                txttaskName.Enabled = false;
                rtxtremark.Enabled = false;
                btnsave.Enabled = false;
                btncancel.Enabled = false;
                btnmodify.Enabled = false;
                btnadd.Enabled = true;
                cmbactivity.Enabled = false;
            }
            if (flag == 3)
            {
                txttaskName.Enabled = true;
                rtxtremark.Enabled = true;
                btnadd.Enabled = false;
                btnsave.Enabled = false;
                btncancel.Enabled = true;
                btnmodify.Enabled = true;
                cmbactivity.Enabled = true;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            enabledisablebuttons(1);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            obj.clearControls(gbxtaskmanagement);
            enabledisablebuttons(2);
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
                if (txttaskName.Text == "")
                {
                    MessageBox.Show("Please Enter Task Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttaskName.Select();
                    return;
                }
                if (rtxtremark.Text == "")
                {
                    MessageBox.Show("Please enter Task Description!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rtxtremark.Select();
                    return;
                }
                obj.FireQuery("Update tbl_task Set taskname='" + txttaskName.Text + "',taskdescription='" + rtxtremark.Text + "',activityid='"+ cmbactivity.SelectedValue +"',Modifydate='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',Isactive='" + chkactive.Checked + "' where taskid='" + taskid + "'");
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbactivity.SelectedIndex == 0)
                {
                    MessageBox.Show("Please Select Activity Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txttaskName.Text == "")
                {
                    MessageBox.Show("Please Enter Task Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttaskName.Select();
                    return;
                }
                if (rtxtremark.Text == "")
                {
                    MessageBox.Show("Please enter Task Description!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rtxtremark.Select();
                    return;
                }
                if (chkactive.Checked == false)
                {
                    MessageBox.Show("Please Confirm Active Activity!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                obj.FireQuery("insert into tbl_task(taskname,taskdescription,activityid,isactive,Createddate)Values('" + txttaskName.Text + "','" + rtxtremark.Text + "','"+ cmbactivity.SelectedValue +"','" + chkactive.Checked + "','" + DateTime.Now.ToString("yyyy - MM - dd HH: mm:ss") + "')");
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

        private void DefineTask_Load(object sender, EventArgs e)
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
        public void GetAllData()
        {
            dview.DataSource = null;
            dview.DataSource = obj.GetDataFromTable("Select ROW_NUMBER()OVER (ORDER BY taskid)SLNO,activityname as [Activity Name],taskName as [Task Name],taskdescription as [Task Description],Isactive,taskid,activityid from View_taskrelateactivity where IsActive=1").Tables[0];
            dview.Columns[0].Width = 50;
            dview.Columns[1].Width = 200;
            dview.Columns[2].Width = 300;
            dview.Columns[3].Width = 600;
            dview.Columns[4].Visible = false;
            dview.Columns[5].Visible = false;
            dview.Columns[6].Visible = false;
            dview.ReadOnly = true;

        }

        private void dview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                taskid = 0;
                int index = dview.CurrentRow.Index;
                if (index <= dview.RowCount - 1)
                {
                    activityid=Convert.ToInt32(dview.Rows[index].Cells[6].Value);
                    cmbactivity.SelectedValue = Convert.ToString(dview.Rows[index].Cells[6].Value); 
                    txttaskName.Text = Convert.ToString(dview.Rows[index].Cells[2].Value);
                    rtxtremark.Text = Convert.ToString(dview.Rows[index].Cells[3].Value);
                    chkactive.Checked = Convert.ToBoolean(dview.Rows[index].Cells[4].Value);
                    taskid = Convert.ToInt32(dview.Rows[index].Cells[5].Value);
                    enabledisablebuttons(3);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbactivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbactivity.SelectedIndex>0)
                { 
                dview.DataSource = null;
                dview.DataSource = obj.GetDataFromTable("Select ROW_NUMBER()OVER (ORDER BY taskid)SLNO,activityname as [Activity Name],taskName as [Task Name],taskdescription as [Task Description],Isactive,taskid,activityid from View_taskrelateactivity where IsActive=1 and activityid='"+ cmbactivity.SelectedValue +"'").Tables[0];
                dview.Columns[0].Width = 50;
                dview.Columns[1].Width = 200;
                dview.Columns[2].Width = 300;
                dview.Columns[3].Width = 600;
                dview.Columns[4].Visible = false;
                dview.Columns[5].Visible = false;
                dview.Columns[6].Visible = false;
                dview.ReadOnly = true;
                }
                else
                {
                    GetAllData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
