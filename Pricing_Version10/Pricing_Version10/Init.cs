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
            if (fForm1.IsDisposed == true)
            {
                fForm1 = new Form1();
            }
            
            fForm1.Show();
        }

        fAddMerchant formAdd = new fAddMerchant();

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (formAdd.IsDisposed == true)
            {
                formAdd = new fAddMerchant();
            }
            
            formAdd.Show();
        }

        Raw fRaw = new Raw();

        private void lkRaw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (fRaw.IsDisposed == true)
            {
                fRaw = new Raw();
            }
            
            fRaw.Show();
        }

        Analysis fAnalysis = new Analysis();

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (fAnalysis.IsDisposed == true)
            {
                fAnalysis = new Analysis();
            }
            
            fAnalysis.Show();
        }

    }
}
