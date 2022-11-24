using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Security;
namespace TMS.App_Code
{
   static class Global
    {
        public static string ConnectedServerName=null;
        public static string connecteddatabasename=null;
        public static string dbname;

        //Function to handle spoecial Char in the password field it converts Special Char 
        public static string ClearUpperQmark(string Str)
        {
            string temp = "";
            if(Str!=null)
            {
                for (int m = 0; m <= Str.Length-1; m++)
                {
                    if (Str.Substring(m,1) != Convert.ToString(39))
                    {
                        temp = temp + Str.Substring(m, 1);
                    }
                    else
                    {
                        temp = temp + ((char)39).ToString() + ((char)39).ToString();

                    }
                }
            }
            return temp;
             
        }

    }
}
