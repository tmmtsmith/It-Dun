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
            string q1 = "SELECT * FROM view_Analysis";
            string q2 = "SELECT * FROM view_3MoAnalysis";
            string q3 = "SELECT * FROM view_SalesApproachNotes";
            string q4 = "SELECT * FROM view_ClosedEarliestRecent";
            string q5 = "SELECT * FROM view_Cost";

            using (var scon = Connections.Connect())
            {
                if (sl == "Conversion Rates")
                {
                    ReturnTables.RefreshReturnGridView(dAnalysis, q1, scon);
                }
                else if (sl == "Three Month Conversion Rates")
                {
                    ReturnTables.RefreshReturnGridView(dAnalysis, q2, scon);
                }
                else if (sl == "Sales Approach Notes")
                {
                    ReturnTables.RefreshReturnGridView(dAnalysis, q3, scon);
                }
                else if (sl == "Earliest/Latest Close")
                {
                    ReturnTables.RefreshReturnGridView(dAnalysis, q4, scon);
                }
                else if (sl == "Cost Analysis")
                {
                    ReturnTables.RefreshReturnGridView(dAnalysis, q5, scon);
                }
                // Add 3 reports (also, highlights)
                scon.Close();
            }

        }
    }
}
