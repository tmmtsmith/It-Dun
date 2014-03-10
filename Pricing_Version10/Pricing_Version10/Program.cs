using System;
using System.Collections.Generic;
using System.Data;
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

    public static class ReturnTables
    {
        public static DataGridView ReturnGridView(DataGridView dG, string query)
        {
            using (var scon = Connections.Connect())
            {
                SqlCommand queryGrid = new SqlCommand(query, scon);
                SqlDataAdapter sAdapt = new SqlDataAdapter(queryGrid);
                sAdapt.SelectCommand = queryGrid;
                DataTable dTab = new DataTable();
                sAdapt.Fill(dTab);
                BindingSource b = new BindingSource();
                b.DataSource = dTab;
                dG.DataSource = b;
                sAdapt.Update(dTab);
                scon.Close();
                return dG;
            }
        }
    }
}
