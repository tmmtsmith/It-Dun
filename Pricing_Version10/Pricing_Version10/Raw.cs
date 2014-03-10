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
    public partial class Raw : Form
    {
        public Raw()
        {
            InitializeComponent();
            string q = "SELECT * FROM view_Raw";
            ReturnTables.ReturnGridView(dGridView, q);
        }
    }
}
