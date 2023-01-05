using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.Controls.TeamRegisterandManage
{
    public partial class addrole : Form
    {
        private Random random;
        App_Code.CodeTMS obj = new App_Code.CodeTMS();
        public addrole()
        {
            InitializeComponent();
            LoadTheme();
            random = new Random();
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
            btnaddrole.ForeColor = ThemeColor.SecondaryColor;
            lblrole.BackColor = ThemeColor.SecondaryColor;
            txtRole.ForeColor = ThemeColor.SecondaryColor;
        }
        private void addrole_Load(object sender, EventArgs e)
        {

        }

        private void btnaddrole_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtRole.Text!="")
                {
                    DataTable dt = new DataTable();
                    dt = obj.GetDataFromTable("Select RoleName from RoleMaster where RoleName='" + txtRole.Text + "'").Tables[0];
                    if (dt.Rows.Count <= 0)
                    {
                        obj.FireQuery("insert into RoleMaster(RoleName,Isadmin)Values('" + txtRole.Text + "','1')");
                        MessageBox.Show("Data Saved Successfully!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtRole.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Role: '" + txtRole.Text + "' already exit in Database!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter RoleName!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
                   
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
