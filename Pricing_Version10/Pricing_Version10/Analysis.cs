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
                dAnalysis.RowsDefaultCellStyle.BackColor = Color.White;
                dAnalysis.AlternatingRowsDefaultCellStyle.BackColor = Color.PowderBlue;
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

            using (var scon = Connections.Connect())
            {
                if (sl == "Conversion Rates")
                {
                    ReturnTables.RefreshReturnGridView(dAnalysis, Reports.reportOne, scon);
                }
                else if (sl == "Three Month Conversion Rates")
                {
                    ReturnTables.RefreshReturnGridView(dAnalysis, Reports.reportTwo, scon);
                }
                else if (sl == "Sales Approach Notes")
                {
                    ReturnTables.RefreshReturnGridView(dAnalysis, Reports.reportThree, scon);
                }
                else if (sl == "Earliest/Latest Close")
                {
                    ReturnTables.RefreshReturnGridView(dAnalysis, Reports.reportFour, scon);
                }
                else if (sl == "Cost Analysis")
                {
                    ReturnTables.RefreshReturnGridView(dAnalysis, Reports.reportFive, scon);
                }
                // Add 3 reports (also, highlights)
                scon.Close();
            }

        }
    }
}
