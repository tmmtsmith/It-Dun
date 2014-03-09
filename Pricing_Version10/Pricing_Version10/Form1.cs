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
                SqlCommand qMer = new SqlCommand("SELECT DISTINCT ApproachName FROM ApproachList", scon);
                SqlDataReader rMer = qMer.ExecuteReader();

                while (rMer.Read())
                {
                    cbMerchants.Items.Add(rMer["ApproachName"].ToString());
                }

                scon.Close();
            }
        }

        private void cbMerchants_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLeads.Text == "" && txtTrial.Text == "" && txtClose.Text == "")
            {
                MessageBox.Show("At least one box must hold a numeric value.");
            }
            else
            {
                using (var scon = Connections.Connect())
                {
                    try
                    {
                        SqlCommand addRes = new SqlCommand("INSERT INTO StageResults (mName,cLeads,cTrial,cClose) SELECT @1,@2,@3,@4", scon);
                        addRes.Parameters.Add(new SqlParameter("@1", cbMerchants.SelectedItem.ToString()));
                        addRes.Parameters.Add(new SqlParameter("@2", txtLeads.Text));
                        addRes.Parameters.Add(new SqlParameter("@3", txtTrial.Text));
                        addRes.Parameters.Add(new SqlParameter("@4", txtClose.Text));
                        addRes.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Either connection to the database failed, or you entered invalid values.");
                    }
                    finally
                    {
                        SqlCommand move = new SqlCommand("EXECUTE stp_Move", scon);
                        move.ExecuteNonQuery();
                        scon.Close();
                    }
                }

                txtLeads.Text = String.Empty;
                txtTrial.Text = String.Empty;
                txtClose.Text = String.Empty;
                cbMerchants.SelectedIndex = -1;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtLeads.Text = String.Empty;
            txtTrial.Text = String.Empty;
            txtClose.Text = String.Empty;
            cbMerchants.SelectedIndex = -1;
        }

        fAddMerchant formAdd = new fAddMerchant();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {  
            formAdd.ShowDialog();
        }
    }
}
