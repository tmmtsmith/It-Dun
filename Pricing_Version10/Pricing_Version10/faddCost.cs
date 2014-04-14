using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pricing_Version10
{
    public partial class faddCost : Form
    {
        public faddCost()
        {
            InitializeComponent();

            //ReturnCombo.GetCombo(cbSales, "SELECT DISTINCT SalesApproach FROM SalesList");
            ReturnCombo.GetCombo(cbSales, "SELECT DISTINCT SalesApproach FROM SalesList", "SalesApproach");
        }

        private void btnAddCost_Click(object sender, EventArgs e)
        {
            if (txtCost.Text == "" && cbSales.SelectedIndex == -1 && cbCP.SelectedIndex == -1)
            {
                MessageBox.Show("Error: Ensure that you selected an item from Sales Approach, Cost Per, and entered a valid Cost.");
            }
            else
            {
                using (var scon = Connections.Connect())
                {
                    try
                    {
                        // Add Cost
                        SqlCommand addCost = new SqlCommand("EXECUTE stp_AddCost @1,@2,@3", scon);
                        addCost.Parameters.Add(new SqlParameter("@1", cbSales.SelectedItem.ToString()));
                        addCost.Parameters.Add(new SqlParameter("@2", cbCP.SelectedItem.ToString()));
                        addCost.Parameters.Add(new SqlParameter("@3", txtCost.Text));
                        addCost.ExecuteNonQuery();
                        scon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failure to connect to the database.");
                        LogErrors.LogError("Add Cost", ex.Message, "Failed to add cost to database.");
                    }
                }
            }

            txtCost.Text = String.Empty;
            cbSales.SelectedIndex = -1;
            cbCP.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
