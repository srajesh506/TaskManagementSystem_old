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
    public partial class TaskCalender_New : Form
    {
        public TaskCalender_New()
        {
            InitializeComponent();
        }
        public void Display()
        {
            DateTime now = DateTime.Now;
            //Let's get the first day of month
            DateTime startofthemonth = new DateTime(now.Year, now.Month, 1);
            //get the count of days of the month
            int days = DateTime.DaysInMonth(now.Year, now.Month);
            //convert the startdaysofmonthintointeger
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"))+1;

            //First Let's Create a Blank UserControl

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //now lets create usercontrol for days
            for (int i=1; i<=days;i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void TaskCalender_New_Load(object sender, EventArgs e)
        {
            Display();
        }
    }
}
