using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pricing_Version10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (var scon = Connections.Connect())
            {
                SqlCommand qMer = new SqlCommand("SELECT DISTINCT MerchantName FROM MerchantList", scon);
                SqlDataReader rMer = qMer.ExecuteReader();

                while (rMer.Read())
                {
                    cbMerchants.Items.Add(rMer["MerchantName"].ToString());
                }

                scon.Close();
            }
        }

        private void cbMerchants_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
