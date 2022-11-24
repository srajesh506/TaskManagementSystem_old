using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TMS.MDI;
using TMS.App_Code;
using TMS.Home.wait;
using System.Threading;

namespace TMS
{
    public partial class Login : Form
    {
        App_Code.CodeTMS obj = new App_Code.CodeTMS();
        string username, userrole, userid;
        waitformfunc waitform = new waitformfunc();
        public Login()
        {
            
            InitializeComponent();
            txtusername.Select();
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            focustxtusername();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            focustxtpwd();
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtpwd.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtpwd.UseSystemPasswordChar = true;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            focustxtusername();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                waitform.Show(this);
                Thread.Sleep(2000);
                DoLogin();
                waitform.Close();
            }
            catch
            {

            }
           
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            focustxtpwd();
        }

        public void DoLogin()
        {
            if (txtusername.Text == "")
            {
                focustxtusername();
                txtusername.Select();
                MessageBox.Show("Please enter the User Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtpwd.Text == "")
            {
                MessageBox.Show("Please enter the Password!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtpwd.Select();
                return;
            }
            if (CheckLogin(Global.ClearUpperQmark(txtusername.Text), txtpwd.Text) == true)
            {
                var frm = new FormMainMenu();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid User or Password!!", "TMS", MessageBoxButtons.OK);
            }
        }
        public bool CheckLogin(string userid, string pwd)
        {
            string RoleName = "";
            int Roleid;
            int IsAdmin;
            DataTable dt = new DataTable();
            //App_Code.CodeTMS obj = new App_Code.CodeTMS();
            try
            {
                dt = obj.checkuserexistence(userid, obj.encrypt(pwd));
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
        public void focustxtusername()
        {
            txtusername.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txtpwd.BackColor = SystemColors.Control;

        }
        public void focustxtpwd()
        {
            txtpwd.BackColor = Color.White;
            panel4.BackColor = Color.White;
            txtusername.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }
    }
}
