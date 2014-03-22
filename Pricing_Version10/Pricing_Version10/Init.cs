using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Pricing_Version10
{
    public partial class Init : Form
    {
        public Init()
        {
            InitializeComponent();
            tt1.SetToolTip(btnAdd, "Add Sales Results");
            tt2.SetToolTip(btnMerch, "Add New Sales Method");
            tt3.SetToolTip(btnRaw, "View Raw Data");
            tt4.SetToolTip(btnAnalysis, "View Sales Results");
            tt5.SetToolTip(txtDis, "Enter the percent as a whole number");
            tt6.SetToolTip(btnHelp, "Get Help");
            tt7.SetToolTip(btnOut, "Output Data To CSV");
        }

        Form1 fForm1 = new Form1();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        fAddMerchant formAdd = new fAddMerchant();

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        Raw fRaw = new Raw();

        private void lkRaw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        Analysis fAnalysis = new Analysis();

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double cpl = Convert.ToDouble(txtCPL.Text);
                double less = Convert.ToDouble(txtLess.Text);
                double dis = Convert.ToDouble(txtDis.Text);
                double ret = Pricing.GetPricing(cpl, less, dis);
                double tt = Pricing.Price(cpl, less);
                double disam = Pricing.GetDiscount(cpl, less, dis);
                txtRes.Clear();
                txtDisAm.Clear();
                txtTt.Clear();

                try
                {
                    txtRes.AppendText("$" + Convert.ToString(ret));
                    txtTt.AppendText("$" + Convert.ToString(tt));
                    txtDisAm.AppendText("$" + Convert.ToString(disam));
                }
                catch
                {
                    MessageBox.Show("Failed to produce final value.");
                }
            }
            catch
            {
                MessageBox.Show("Error: Make sure all of the above boxes are valid numbers.");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control co in Controls)
            {
                if (co is TextBox)
                {
                    (co as TextBox).Clear();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (fForm1.IsDisposed == true)
            {
                fForm1 = new Form1();
            }

            fForm1.Show();
        }

        private void btnMerch_Click(object sender, EventArgs e)
        {
            if (formAdd.IsDisposed == true)
            {
                formAdd = new fAddMerchant();
            }

            formAdd.Show();
        }

        private void btnRaw_Click(object sender, EventArgs e)
        {
            if (fRaw.IsDisposed == true)
            {
                fRaw = new Raw();
            }

            fRaw.Show();
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            if (fAnalysis.IsDisposed == true)
            {
                fAnalysis = new Analysis();
            }

            fAnalysis.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"help.pdf");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string p = @"output\";

            if (!Directory.Exists(p))
            {
                DirectoryInfo d = Directory.CreateDirectory(p);
            }
            
            StreamWriter write = new StreamWriter(p + "output_" + StringDate.GetYYYYMMDDHHStringDate() + ".csv");
            
            using (var scon = Connections.Connect())
            {
                SqlCommand outfile = new SqlCommand("SELECT * FROM view_Out", scon);
                using (SqlDataReader read = outfile.ExecuteReader())
                {
                    using (write)
                    {
                        while (read.Read())
                        {
                            write.WriteLine(read[0].ToString() + "," + read[1].ToString() + "," + read[2].ToString() + "," + read[3].ToString() + "," + read[4].ToString() + "," + read[5].ToString() + "," + read[6].ToString());
                        }
                    }
                }
            }

        }

    }
}
