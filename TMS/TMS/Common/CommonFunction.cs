using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Threading.Tasks;

namespace TMS.App_Code
{
    class CommonFunction
    {
        public string ConString = null;
        public string ConstringServer = null;
        public SqlConnection Con;
        private SqlDataAdapter adp;
        private SqlDataReader Dreader;
        private SqlCommand cmd = new SqlCommand();
        private SqlDataAdapter adapter;
        private DataSet ds;
        public CommonFunction()
        {
            try
            {
                LocalDatabaseCredential();

            }
            catch (Exception ex)
            {
                MessageBox.Show("please check Database Connection!! " + "'" + ex.Message + "'", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        //Function to read AppConfig file for Connection String
        public void LocalDatabaseCredential()
        {
            ConString = ConfigurationManager.ConnectionStrings["constr"].ToString();
            Con = new SqlConnection(ConString);
            Con.Open();
            Global.ConnectedServerName = Con.DataSource;
            Global.connecteddatabasename = Con.Database;
            Global.dbname = Global.connecteddatabasename;

        }
        //Check User Existence from UserDetail Table
        public DataTable checkuserexistence(string empid, string password)
        {
            if (Con.State == ConnectionState.Closed)
            { Con.Open(); }
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string selectcmd;
            DataSet ds = new DataSet();
            selectcmd = "Select RoleName,Roleid,Isadmin from Userdetails where empid='" + empid + "' and password='" + password + "'";
            cmd = new SqlCommand(selectcmd, Con);
            adapter.SelectCommand = cmd;
            adapter.Fill(ds);
            return ds.Tables[0];
        }
        public void CloseConnection()
        {
            Con.Close();
        }
        public void OpenConnection()
        {
            if (Con.State == ConnectionState.Closed)
            { Con.Open(); }
        }

        public void clearControls(GroupBox gp)
        {
            Control form_control = new Control();
            ComboBox cmb = new ComboBox();
            PictureBox pic = new PictureBox();
            CheckedListBox chkbox = new CheckedListBox();
            RichTextBox rtxt = new RichTextBox();
            CheckBox chk = new CheckBox();
            foreach (Control frm in gp.Controls)
            {
                if (frm is TextBox)
                    frm.Text = "";
                if (frm is ComboBox)
                {
                    cmb = frm as ComboBox;
                    cmb.SelectedIndex = 0;
                }
                if (frm is PictureBox)
                {
                    pic = frm as PictureBox;
                    pic.Image = null;
                }
                if (frm is RichTextBox)
                {
                    rtxt = frm as RichTextBox;
                    rtxt.Text = "";
                }
                if (frm is CheckBox)
                {
                    chk = frm as CheckBox;
                    chk.Checked = false;
                }

            }
        }

        public DataSet getworkassignmentitems(bool filterflag = false)
        {
            DataSet ds = new DataSet();
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getworkassignmentitems";
            cmd.Connection = Con;
            cmd.CommandType = CommandType.StoredProcedure;
            if (filterflag)
            {
                cmd.Parameters.Add("@filterflag", SqlDbType.Int).Value = 1;
            }
            else
            {
                cmd.Parameters.Add("@filterflag", SqlDbType.Int).Value = 0;
            }
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }
        public void addworkitem(int activityid, int taskid, int subtaskid, string remark)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "addworkitem";
            cmd.Connection = Con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@activityid", SqlDbType.Int).Value = activityid;
            cmd.Parameters.Add("@taskid", SqlDbType.Int).Value = taskid;
            cmd.Parameters.Add("@subtaskid", SqlDbType.Int).Value = subtaskid;
            cmd.Parameters.Add("@remark", SqlDbType.NVarChar).Value = remark;
            cmd.ExecuteNonQuery();
        }



        public void addworkassignmentitem(int id, int workitemid, int empid, int status, string remarks)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "addworkassignmentitem";
            cmd.Connection = Con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@assigmentitemId", SqlDbType.Int).Value = workitemid;
            cmd.Parameters.Add("@empid", SqlDbType.Int).Value = empid;
            cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;
            cmd.Parameters.Add("@remarks", SqlDbType.NVarChar).Value = remarks;
            cmd.ExecuteNonQuery();
        }
        public void FireQuery(string Query)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            SqlCommand cmd = new SqlCommand(Query, Con);
            cmd.ExecuteNonQuery();
        }
        public int GetMaxId(string tablename, string fieldname)
        {
            int maxid;

            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            string selectcmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            selectcmd = "Select Max(" + fieldname + ") maxid from " + tablename + "";
            cmd = new SqlCommand(selectcmd, Con);
            Adapter.SelectCommand = cmd;
            Adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                maxid = String.IsNullOrEmpty(ds.Tables[0].Rows[0]["maxid"].ToString()) ? 1 : Convert.ToInt32(ds.Tables[0].Rows[0]["maxid"].ToString()) + 1;
                //maxid = Convert.ToInt32(ds.Tables[0].Rows[0]["maxid"]) + 1;
            }
            else
            {
                maxid = 1;
            }
            return maxid;

        }
        public string GetEmpnameandID(string tablename, string fieldname, int empid)
        {
            var value = "";

            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            string selectcmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            selectcmd = "Select Max(" + fieldname + ") maxid from " + tablename + " where empid=" + empid + "";
            cmd = new SqlCommand(selectcmd, Con);
            Adapter.SelectCommand = cmd;
            Adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                value = ds.Tables[0].Rows[0]["maxid"].ToString();


            }
            return value;

        }
        public DataSet GetDataFromTable(string Query)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            string selectCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            DataSet DS = new DataSet();
            selectCmd = Query;
            cmd = new SqlCommand(selectCmd, Con);
            Adapter.SelectCommand = cmd;
            Adapter.Fill(DS);
            return DS;

        }
        public int GetDataCountFromTable(string Query)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            string selectCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            DataSet DS = new DataSet();
            selectCmd = Query;
            cmd = new SqlCommand(selectCmd, Con);
            Adapter.SelectCommand = cmd;
            Adapter.Fill(DS);
            return Convert.ToInt32(DS.Tables[0].Rows[0]["data"]);

        }
        public string encrypt(string encryptString)
        {
            string EncryptionKey = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptString = Convert.ToBase64String(ms.ToArray());
                }
            }
            return encryptString;
        }
        public string Decrypt(string cipherText)
        {
            try
            {
                string EncryptionKey = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                cipherText = cipherText.Replace(" ", "+");
                byte[] cipherBytes = Convert.FromBase64String(cipherText);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }
                        cipherText = Encoding.Unicode.GetString(ms.ToArray());
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return cipherText;

        }
    }
}
