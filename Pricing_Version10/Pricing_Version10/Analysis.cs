using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
