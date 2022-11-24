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
    public partial class GroupTask : Form
    {
        public GroupTask()
        {
            InitializeComponent();
            LoadTheme();
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
            btnmanage.ForeColor = ThemeColor.PrimaryColor;
            //btnmanage.BackColor = ThemeColor.PrimaryColor;
            lbltaskgroup.ForeColor = ThemeColor.SecondaryColor;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
