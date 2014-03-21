﻿using System;
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

    public static class Connections
    {
        public static SqlConnection Connect()
        {
            SqlConnection scon = new SqlConnection(@"integrated security=SSPI;data source=TIMOTHY\SQLEXPRESS;persist security info=False;initial catalog=KPS");
            scon.Open();
            return scon;
        }

        public static string GetFiles(string src, string dest)
        {
            try
            {
                WebClient getFile = new WebClient();
                getFile.DownloadFile(src, dest);
                return "Success";
            }
            catch
            {
                return "Failure";
            }
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
        public static string GetStringDate()
        {
            DateTime now = DateTime.Now;

            if (now.Month.ToString().Length == 1)
            {
                string moString = "0" + now.Month.ToString();

                if (now.Day.ToString().Length == 1)
                {
                    string dayString = "0" + now.Day.ToString();
                    return now.Year.ToString() + moString + dayString + now.Minute.ToString();
                }
                else
                {
                    string dayString = now.Day.ToString();
                    return now.Year.ToString() + moString + dayString + now.Minute.ToString();
                }
            }
            else
            {
                string moString = now.Month.ToString();

                if (now.Day.ToString().Length == 1)
                {
                    string dayString = "0" + now.Day.ToString();
                    return now.Year.ToString() + moString + dayString + now.Minute.ToString();
                }
                else
                {
                    string dayString = now.Day.ToString();
                    return now.Year.ToString() + moString + dayString + now.Minute.ToString();
                }
            }

        }
    }
}
