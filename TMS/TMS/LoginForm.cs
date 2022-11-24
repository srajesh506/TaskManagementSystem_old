using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.MDI;
using TMS.App_Code;

namespace TMS
{
    public partial class LoginForm : Form
    {
        App_Code.CodeTMS obj = new App_Code.CodeTMS();
        string User_Name, User_Roles, User_Id;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            DoLogin();
        }
        public void DoLogin()
        {
            if(txtusername.Text=="")
            {
                MessageBox.Show("Please enter the User Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtusername.Select();
                return;
            }
            if (txtpwd.Text == "") {
                MessageBox.Show("Please enter the Password!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtpwd.Select();
                return;
            }

            if(CheckLogin(Global.ClearUpperQmark(txtusername.Text), txtpwd.Text)==true)
            {
                var frm = new MDIMain();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid User or Password!!", "TMS", MessageBoxButtons.OK);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        public bool CheckLogin(string userid,string pwd)
        {
            string RoleName="";
            int Roleid;
            int IsAdmin;
            DataTable dt=new DataTable();
            //App_Code.CodeTMS obj = new App_Code.CodeTMS();
            try
            {
                dt = obj.checkuserexistence(userid, pwd);
                if (dt.Rows.Count > 0)
                    RoleName = dt.Rows[0]["RoleName"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"TMS");
            }
            if (RoleName!="")
            {
                User_Name = userid; User_Roles = RoleName;Roleid = Convert.ToInt32(dt.Rows[0]["Roleid"]);
                if (dt.Rows[0]["IsAdmin"] != System.DBNull.Value)
                    return true;
                else
                    return false;
            }
            return false;
            
        }
    }
}
