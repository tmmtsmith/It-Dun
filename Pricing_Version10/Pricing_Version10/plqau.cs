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
    public partial class plqau : Form
    {
        public plqau()
        {
            InitializeComponent();

            //ReturnCombo.GetCombo(cbSales, "SELECT DISTINCT SalesApproach FROM SalesList");
            //ReturnCombo.GetCombo(cbSales, "SELECT DISTINCT SalesApproach FROM SalesList", "SalesApproach");
        }

        private void plqau_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCost_Click(object sender, EventArgs e)
        {
            // Changed
        }
    }
}
