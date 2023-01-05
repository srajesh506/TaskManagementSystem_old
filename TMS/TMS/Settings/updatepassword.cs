using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Runtime.InteropServices.ComTypes;
using TMS.MDI;
using TMS.App_Code;

namespace TMS.Controls.TeamRegisterandManage
{
    public partial class updatepassword : Form
    {
        App_Code.CodeTMS obj = new App_Code.CodeTMS();
        string username, userrole, userid;
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //private static extern IntPtr CreateRoundRectRgn
        //    (
        //       int nLeftRect,
        //       int nTopRect,
        //       int nRightRect,
        //       int nBottomRect,
        //       int nWidthEllipse,
        //       int nHeightEllipse
        //    );
        public updatepassword()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

       

        private void picoldpwd_MouseDown(object sender, MouseEventArgs e)
        {
            txtoldpwd.UseSystemPasswordChar = false;
        }

        private void picnewpwd_MouseDown(object sender, MouseEventArgs e)
        {
            txtnewpwd.UseSystemPasswordChar = false;
        }

        private void picnewconfirmpwd_MouseDown(object sender, MouseEventArgs e)
        {
            txtnewconfirmpwd.UseSystemPasswordChar = false;
        }

        private void picoldpwd_MouseUp(object sender, MouseEventArgs e)
        {
            txtoldpwd.UseSystemPasswordChar = true;
        }

        private void picnewpwd_MouseUp(object sender, MouseEventArgs e)
        {
            txtnewpwd.UseSystemPasswordChar = true;
        }

        private void picnewconfirmpwd_MouseUp(object sender, MouseEventArgs e)
        {
            txtnewconfirmpwd.UseSystemPasswordChar = true;
        }

        

        private void txtoldpwd_MouseEnter(object sender, EventArgs e)
        {

            if (txtoldpwd.Text == "Type your old Password" && txtoldpwd.Text != "")
            {
                txtoldpwd.UseSystemPasswordChar = true;
                txtoldpwd.Text = "";
            }

        }

        private void txtoldpwd_MouseLeave(object sender, EventArgs e)
        {
            if (txtoldpwd.Text == "")
            {
                txtoldpwd.UseSystemPasswordChar = false;
                txtoldpwd.Text = "Type your old Password";

            }
        }

        private void txtnewpwd_MouseEnter(object sender, EventArgs e)
        {

            if (txtnewpwd.Text == "Type your New Password" && txtnewpwd.Text != "")
            {
                txtnewpwd.UseSystemPasswordChar = true;
                txtnewpwd.Text = "";
            }
        }

        private void txtnewpwd_MouseLeave(object sender, EventArgs e)
        {
            if (txtnewpwd.Text == "")
            {
                txtnewpwd.UseSystemPasswordChar = false;
                txtnewpwd.Text = "Type your New Password";

            }
        }

        private void txtnewconfirmpwd_MouseEnter(object sender, EventArgs e)
        {

            if (txtnewconfirmpwd.Text == "Type your Confirm Password" && txtnewconfirmpwd.Text != "")
            {
                txtnewconfirmpwd.UseSystemPasswordChar = true;
                txtnewconfirmpwd.Text = "";
            }
        }

        private void txtnewconfirmpwd_MouseLeave(object sender, EventArgs e)
        {
            if (txtnewconfirmpwd.Text == "")
            {
                txtnewconfirmpwd.UseSystemPasswordChar = false;
                txtnewconfirmpwd.Text = "Type your Confirm Password";

            }
        }

        private void picoldpwd_MouseUp_1(object sender, MouseEventArgs e)
        {

        }

        private void picnewpwd_MouseDown_1(object sender, MouseEventArgs e)
        {

        }

        private void picnewpwd_MouseUp_1(object sender, MouseEventArgs e)
        {

        }

        private void picnewconfirmpwd_MouseDown_1(object sender, MouseEventArgs e)
        {

        }

        private void picnewconfirmpwd_MouseUp_1(object sender, MouseEventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string empid;
                empid = Global.GlobalVar;
                if (txtoldpwd.Text == "Type your old Password")
                {
                    txtoldpwd.Select();
                    MessageBox.Show("Please enter your old Password!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtnewpwd.Text == "Type your New Password")
                {
                    txtnewpwd.Select();
                    MessageBox.Show("Please enter your New Password!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtnewconfirmpwd.Text == "Type your Confirm Password")
                {
                    txtnewconfirmpwd.Select();
                    MessageBox.Show("Please enter Confirm Password!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                    //Dear "+ obj.GetEmpnameandID("UserDetails","EmpName",int.Parse(Global.GlobalVar)) +"..
                }
                if (CheckLogin(Global.ClearUpperQmark(Global.GlobalVar), txtoldpwd.Text) == true)
                {
                    if(txtnewpwd.Text==txtnewconfirmpwd.Text)
                    {
                        obj.FireQuery("Update UserMaster Set Modifydate='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',Password='" + obj.encrypt(txtnewconfirmpwd.Text) + "' where empid='" + Global.GlobalVar + "'");
                        obj.clearControls(grbpwd);
                        MessageBox.Show("Password Changed Successfully!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("New Password and Confirm Password does not match!", "TMS", MessageBoxButtons.OK);
                        txtnewconfirmpwd.Text = "";
                        txtnewconfirmpwd.Select();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Old Password!!", "TMS", MessageBoxButtons.OK);
                    txtoldpwd.Select();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool CheckLogin(string empid, string pwd)
        {
            string RoleName = "";
            int Roleid;
            int IsAdmin;
            DataTable dt = new DataTable();
            //App_Code.CodeTMS obj = new App_Code.CodeTMS();
            try
            {
                dt = obj.checkuserexistence(empid, obj.encrypt(pwd));
                if (dt.Rows.Count > 0)
                    RoleName = dt.Rows[0]["RoleName"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TMS");
            }
            if (RoleName != "")
            {
                username = userid; userrole = RoleName; Roleid = Convert.ToInt32(dt.Rows[0]["Roleid"]);
                if (dt.Rows[0]["IsAdmin"] != System.DBNull.Value)
                    return true;
                else
                    return false;
            }
            return false;

        }
    }
}
