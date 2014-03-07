namespace Pricing_Version10
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbMerchants = new System.Windows.Forms.ComboBox();
            this.txtLeads = new System.Windows.Forms.TextBox();
            this.txtTrial = new System.Windows.Forms.TextBox();
            this.txtClose = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMerchants
            // 
            this.cbMerchants.FormattingEnabled = true;
            this.cbMerchants.Location = new System.Drawing.Point(3, 3);
            this.cbMerchants.Name = "cbMerchants";
            this.cbMerchants.Size = new System.Drawing.Size(130, 21);
            this.cbMerchants.TabIndex = 0;
            this.cbMerchants.SelectedIndexChanged += new System.EventHandler(this.cbMerchants_SelectedIndexChanged);
            // 
            // txtLeads
            // 
            this.txtLeads.Location = new System.Drawing.Point(139, 3);
            this.txtLeads.Name = "txtLeads";
            this.txtLeads.Size = new System.Drawing.Size(34, 20);
            this.txtLeads.TabIndex = 1;
            // 
            // txtTrial
            // 
            this.txtTrial.Location = new System.Drawing.Point(184, 3);
            this.txtTrial.Name = "txtTrial";
            this.txtTrial.Size = new System.Drawing.Size(34, 20);
            this.txtTrial.TabIndex = 2;
            // 
            // txtClose
            // 
            this.txtClose.Location = new System.Drawing.Point(229, 3);
            this.txtClose.Name = "txtClose";
            this.txtClose.Size = new System.Drawing.Size(34, 20);
            this.txtClose.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.cbMerchants, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtClose, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLeads, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTrial, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(272, 35);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 220);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Pricing";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMerchants;
        private System.Windows.Forms.TextBox txtLeads;
        private System.Windows.Forms.TextBox txtTrial;
        private System.Windows.Forms.TextBox txtClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

