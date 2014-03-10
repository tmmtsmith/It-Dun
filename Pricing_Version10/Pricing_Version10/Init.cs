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
    public partial class Init : Form
    {
        public Init()
        {
            InitializeComponent();
        }

        Form1 fForm1 = new Form1();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fForm1.ShowDialog();
        }

        fAddMerchant formAdd = new fAddMerchant();

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formAdd.ShowDialog();
        }
    }
}
