using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            ReturnCombo.GetCombo(cbSales, "SELECT DISTINCT SalesApproach FROM SalesList");
        }

        private void plqau_Load(object sender, EventArgs e)
        {

        }
    }
}
