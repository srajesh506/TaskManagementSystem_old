using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.Controls.TeamRegisterandManage;

namespace TMS.Home
{
    public partial class TeamRegister : Form
    {
        public TeamRegister()
        {
            InitializeComponent();
            addControl(new TeamRegisterView());
            panelHome.BackColor = Color.MediumSeaGreen;
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
            //grpboxmember.ForeColor = ThemeColor.PrimaryColor;
           
        }
        private void addControl(Control usercontrol)
        {
            
            usercontrol.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }
        private void btn_click(object sender, EventArgs e)
        {
            foreach (var pnl in tableLayoutPanel1.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.Silver;
            }
            Button btn = (Button)sender;
            switch(btn.Name)
            {
                case "btnhome":
                    addControl(new TeamRegisterView());
                    panelHome.BackColor = Color.MediumSeaGreen;
                    break;
                case "btnManage":
                    addControl(new Manage());
                    panelManage.BackColor = Color.MediumSeaGreen;
                    break;
                default:
                    break;
            }
        }
    }
}
