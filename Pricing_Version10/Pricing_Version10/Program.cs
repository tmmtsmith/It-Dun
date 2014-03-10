using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pricing_Version10
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Init());
        }
    }

    public static class Connections
    {
        public static SqlConnection Connect()
        {
            SqlConnection scon = new SqlConnection(@"integrated security=SSPI;data source=TIMOTHY\SQLEXPRESS;persist security info=False;initial catalog=ClientMarketing");
            scon.Open();
            return scon;
        }
    }
}
