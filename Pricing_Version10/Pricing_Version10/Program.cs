using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;

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

        public static DataGridView RefreshReturnGridView(DataGridView dgv, string query, SqlConnection scon)
        {
            SqlCommand queryGrid = new SqlCommand(query, scon);
            SqlDataAdapter sAdapt = new SqlDataAdapter(queryGrid);
            sAdapt.SelectCommand = queryGrid;
            DataTable dTab = new DataTable();
            sAdapt.Fill(dTab);
            BindingSource b = new BindingSource();
            b.DataSource = dTab;
            dgv.DataSource = b;
            sAdapt.Update(dTab);
            return dgv;
        }
    }

    public static class Pricing
    {
        public static double GetPricing(double cost, double lessons, double discount)
        {
            double a = (cost * lessons);
            discount = (discount / 100);
            double x = (a * discount);
            double y = a - x;
            return y;
        }

        public static double GetDiscount(double cost, double lessons, double discount)
        {
            double a = (cost * lessons);
            discount = (discount / 100);
            double x = (a * discount);
            return x;
        }

        public static double Price(double cost, double lessons)
        {
            double a = (cost * lessons);
            return a;
        }
    }

    public static class StringDate
    {
        public static string GetYYYYMMDDHHStringDate()
        {
            DateTime now = DateTime.Now;
            string y = now.Year.ToString();
            string m = now.Month.ToString();
            string d = now.Day.ToString();
            string h = now.Hour.ToString();

            // Month
            if (m.Length == 1)
            {
                m = "0" + m;
            }

            // Day
            if (d.Length == 1)
            {
                d = "0" + d;
            }

            // Hour
            if (h.Length == 1)
            {
                h = "0" + h;
            }

            return y + m + d + h;

        }
    }
}
