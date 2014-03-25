using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Pricing_Version10
{
    public partial class Analysis : Form
    {
        public Analysis()
        {
            InitializeComponent();
           
            string a = "SELECT * FROM view_Analysis";
            using (var scon = Connections.Connect())
            {
                ReturnTables.RefreshReturnGridView(dAnalysis, a, scon);
                scon.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sl = cbReport.SelectedItem.ToString();

            if (sl == "Conversion Rates")
            {
                string a = "SELECT * FROM view_Analysis";
                using (var scon = Connections.Connect())
                {
                    ReturnTables.RefreshReturnGridView(dAnalysis, a, scon);
                    scon.Close();
                }
            }
            else if (sl == "Three Month Conversion Rates")
            {
                string a = "SELECT * FROM view_3MoAnalysis";
                using (var scon = Connections.Connect())
                {
                    ReturnTables.RefreshReturnGridView(dAnalysis, a, scon);
                    scon.Close();
                }
            }
            else if (sl == "Other")
            {
                string a = "SELECT * FROM SalesList";
                using (var scon = Connections.Connect())
                {
                    ReturnTables.RefreshReturnGridView(dAnalysis, a, scon);
                    scon.Close();
                }
            }
        }
    }
}
