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
    public partial class fAddMerchant : Form
    {
        public fAddMerchant()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var scon = Connections.Connect())
            {
                SqlCommand addApp = new SqlCommand("INSERT INTO ApproachList (ApproachName) SELECT @1", scon);
                addApp.Parameters.Add(new SqlParameter("@1", txtAddApp.Text));
                addApp.ExecuteNonQuery();
                scon.Close();
            }

            txtAddApp.Text = String.Empty;
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
