using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TMS.Controls.TeamRegisterandManage;

namespace TMS.Home
{
    public partial class frmteamregister : Form
    {
        private Random random;
        private int tempindex;
        static int empid;
        App_Code.CodeTMS obj = new App_Code.CodeTMS();
        public frmteamregister()
        {
           
            InitializeComponent();
            LoadTheme();
            random = new Random();
            enabledisablebuttons(2);
            GetAllData();
            
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
            lblreg.BackColor = ThemeColor.SecondaryColor;
            lblempid.ForeColor = ThemeColor.SecondaryColor;
            lblname.ForeColor = ThemeColor.SecondaryColor;
            lblrole.ForeColor = ThemeColor.SecondaryColor;
            lblemail.ForeColor = ThemeColor.SecondaryColor;
            lblremark.ForeColor = ThemeColor.SecondaryColor;
            groupBoxforregistration.ForeColor= ThemeColor.PrimaryColor;
            groupBoxforbutton.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforexistingemployee.ForeColor = ThemeColor.PrimaryColor;
            chkactive.ForeColor = ThemeColor.SecondaryColor;
            txtempid.ForeColor= ThemeColor.SecondaryColor;
            txtname.ForeColor = ThemeColor.SecondaryColor;
            txtemail.ForeColor = ThemeColor.SecondaryColor;
            rtxtremark.ForeColor = ThemeColor.SecondaryColor;
            txtpwd.ForeColor = ThemeColor.SecondaryColor;
            btnupload.BackColor = ThemeColor.PrimaryColor;
            btnupload.ForeColor = ThemeColor.SecondaryColor;
            //cmbRole.BackColor = ThemeColor.SecondaryColor;
            cmbRole.ForeColor = ThemeColor.SecondaryColor;
            
        }
       

        private void btnupload_Click(object sender, EventArgs e)
        {
            string imagelocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if(dialog.ShowDialog()==DialogResult.OK)
                {
                    imagelocation = dialog.FileName;
                    pic.ImageLocation = imagelocation;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("An error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtempid.Text == "")
                {
                    MessageBox.Show("Please enter employeeid!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (txtname.Text == "")
                {
                    MessageBox.Show("Please enter Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cmbRole.SelectedIndex==0)
                {
                    MessageBox.Show("Please Select Role!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtemail.Text == "")
                {
                    MessageBox.Show("Please enter EmailId!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //int status = ValidateEmailId(txtemail.Text);
                //if (status == 0)
                //{
                //    MessageBox.Show("E-Mail Id expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                //else if (status == 2)
                //{
                //    MessageBox.Show("Please enter E-mail Id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                if (rtxtremark.Text == "")
                {
                    MessageBox.Show("Please enter Remark!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtpwd.Text == "")
                {
                    MessageBox.Show("Please enter Password!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (chkactive.Checked == false)
                {
                    MessageBox.Show("Please Confirm Active Member!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
               
                int maxid = obj.GetMaxId("UserMaster", "Roleid");
                if (!File.Exists(Application.StartupPath + "\\Image\\" + txtempid.Text + ".jpg"))
                {
                if (pic.Image != null)
                {
                    using (Bitmap bmb = new Bitmap(pic.Image))
                    {
                        //pictureBox1.Image.Save(Application.StartupPath + "\\Image\\" + maxid + ".jpg");
                        MemoryStream m = new MemoryStream();
                        bmb.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    using (Bitmap bmb = (Bitmap)pic.Image.Clone())
                    {
                        bmb.Save(Application.StartupPath + "\\Image\\" + txtempid.Text + ".jpg", bmb.RawFormat);
                    }
                        
                }
                }
                DataTable dt = new DataTable();
                dt = obj.GetDataFromTable("Select empid from UserMaster where empid='" + txtempid.Text + "'").Tables[0];
                if(dt.Rows.Count<=0)
                {
                    string imagename=pic.Image== null ? null : txtempid.Text +".jpg";
                    obj.FireQuery("insert into UserMaster(empid,EmpName,Createddate,Isactive,Remark,Roleid,Password,Email,pic)Values('" + txtempid.Text + "','" + txtname.Text + "','" + DateTime.Now.ToString("yyyy - MM - dd HH: mm:ss") + "','" + chkactive.Checked + "','" + rtxtremark.Text + "','" + cmbRole.SelectedValue + "','" + obj.encrypt(txtpwd.Text) + "','" + txtemail.Text + "','" + imagename + "')");
                    GetAllData();
                    obj.clearControls(groupBoxforregistration);
                    MessageBox.Show("Data Saved Successfully!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Employee ID: '"+ txtempid.Text +"' already exit in Database!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        public void enabledisablebuttons(int flag)
        {
            if(flag==0) //
            {
                btnsave.Enabled = false;
                btnmodify.Enabled = false;
                btncancel.Enabled = false;
                btnaddrole.Enabled = false;
            }
            if(flag==1) //Add Data
            {
                txtempid.Enabled = true;
                txtempid.Enabled = true;
                txtempid.Select();
                btnsave.Enabled = true;
                btncancel.Enabled = true;
                btnaddrole.Enabled = true;

                txtname.Enabled = true;
                cmbRole.Enabled = true;
                txtemail.Enabled = true;
                rtxtremark.Enabled = true;
                txtpwd.Enabled = true;
                btnadd.Enabled = false;
            }
            if (flag == 2)//modify and Cancel
            {
                txtempid.Enabled = false;
                txtname.Enabled = false;
                cmbRole.Enabled = false;
                txtemail.Enabled = false;
                rtxtremark.Enabled = false;
                txtpwd.Enabled = false;
                btnsave.Enabled = false;
                btncancel.Enabled = false;
                btnmodify.Enabled = false;
                btnadd.Enabled = true;
                btnaddrole.Enabled = false;
            }
            if (flag == 3)
            {
                txtempid.Enabled = true;
                txtname.Enabled = true;
                cmbRole.Enabled = true;
                txtemail.Enabled = true;
                rtxtremark.Enabled = true;
                txtpwd.Enabled = true;
                btnadd.Enabled = false;
                btnsave.Enabled = false;
                btncancel.Enabled = true;
                btnmodify.Enabled = true;
                txtempid.Enabled = false;
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            enabledisablebuttons(1);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            obj.clearControls(groupBoxforregistration);
            enabledisablebuttons(2);
        }
        public void GetAllData()
        {
            dview.DataSource = null;
            dview.DataSource = obj.GetDataFromTable("Select EmpId as [Employee Id],EmpName as [Employee Name],RoleName as Role,Email,Remark as Remarks,Password,pic,Roleid,Isactive from UserDetails where IsActive=1").Tables[0];
            dview.Columns[0].Width = 150;
            dview.Columns[1].Width = 200;
            dview.Columns[2].Width = 150;
            dview.Columns[3].Width = 300;
            dview.Columns[4].Width = 300;
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
                int index = dview.CurrentRow.Index;
                if (index <= dview.RowCount - 1)
                {
                    //empid = Convert.ToInt32(dview.Rows[index].Cells[7].Value);
                    txtempid.Text = Convert.ToString(dview.Rows[index].Cells[0].Value);
                    empid = Convert.ToInt32(txtempid.Text);
                    txtname.Text = Convert.ToString(dview.Rows[index].Cells[1].Value);
                    cmbRole.SelectedValue = Convert.ToString(dview.Rows[index].Cells[7].Value);
                    txtemail.Text = Convert.ToString(dview.Rows[index].Cells[3].Value);
                    rtxtremark.Text = Convert.ToString(dview.Rows[index].Cells[4].Value);
                    txtpwd.Text = obj.Decrypt(Convert.ToString(dview.Rows[index].Cells[5].Value));
                    chkactive.Checked = Convert.ToBoolean(dview.Rows[index].Cells[8].Value);
                    enabledisablebuttons(3);

                    if (File.Exists(Application.StartupPath + "\\Image\\" + empid + ".jpg"))
                    {
                        pic.Image = Image.FromFile(Application.StartupPath + "\\Image\\" + empid + ".jpg");
                    }
                    else
                    {
                        pic.Image = Image.FromFile(Application.StartupPath + "\\Image\\noimage.png");
                    }

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtempid.Text == "")
                {
                    MessageBox.Show("Please enter employeeid!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (txtname.Text == "")
                {
                    MessageBox.Show("Please enter Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cmbRole.SelectedIndex==0)
                {
                    MessageBox.Show("Please Select Role!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //int status = ValidateEmailId(txtemail.Text);
                //if (status == 0)
                //{
                //    MessageBox.Show("E-Mail Id expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                //else if (status == 2)
                //{
                //    MessageBox.Show("Please enter E-mail Id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                if (txtemail.Text == "")
                {
                    MessageBox.Show("Please enter EmailId!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (rtxtremark.Text == "")
                {
                    MessageBox.Show("Please enter Remark!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtpwd.Text == "")
                {
                    MessageBox.Show("Please enter Password!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!File.Exists(Application.StartupPath + "\\Image\\" + empid + ".jpg"))
                { 
                    if (pic.Image != null)
                {
                    using (Bitmap bmb = new Bitmap(pic.Image))
                    {
                        MemoryStream m = new MemoryStream();
                        bmb.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    using (Bitmap bmb = (Bitmap)pic.Image.Clone())
                    {
                        bmb.Save(Application.StartupPath + "\\Image\\" + empid + ".jpg", bmb.RawFormat);
                    }

                 }
                }
                //DataTable dt = new DataTable();
                //dt = obj.GetDataFromTable("Select empid from UserMaster where empid='" + txtempid.Text + "'").Tables[0];
                //if (dt.Rows.Count <= 0)
                //{
                    obj.FireQuery("Update UserMaster Set empid='" + txtempid.Text + "',EmpName='" + txtname.Text + "',Roleid='" + cmbRole.SelectedValue + "',Modifydate='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',Isactive='" + chkactive.Checked + "',Remark='" + rtxtremark.Text + "',Password='" + obj.encrypt(txtpwd.Text) + "',Email='" + txtemail.Text + "',pic='" + empid + ".jpg' where empid='" + empid + "'");
                    obj.clearControls(groupBoxforregistration);
                    GetAllData();
                    enabledisablebuttons(2);
                    MessageBox.Show("Data modify Successfully!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    MessageBox.Show("Employee ID: '" + txtempid.Text + "' already exit in Database!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmteamregister_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = obj.GetDataFromTable("Select * from RoleMaster");
                DataRow dr;
                dr = ds.Tables[0].NewRow();
                dr.ItemArray = new object[] { 0, "--Select Role--" };
                ds.Tables[0].Rows.InsertAt(dr, 0);
                cmbRole.ValueMember = "Roleid";
                cmbRole.DisplayMember = "RoleName";
                cmbRole.DataSource = ds.Tables[0];
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtempid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        public int ValidateEmailId(string emailId)
        {
            /*Regular Expressions for email id*/
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (emailId.Length > 0)
            {
                if (!rEMail.IsMatch(emailId))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            return 2;
        }

        private void btnaddrole_Click(object sender, EventArgs e)
        {
            addrole frm = new addrole();
            frm.Show();
        }

       
    }
}
