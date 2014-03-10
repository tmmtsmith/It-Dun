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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMerchants
            // 
            this.cbMerchants.FormattingEnabled = true;
            this.cbMerchants.Location = new System.Drawing.Point(3, 3);
            this.cbMerchants.Name = "cbMerchants";
            this.cbMerchants.Size = new System.Drawing.Size(129, 21);
            this.cbMerchants.TabIndex = 0;
            this.cbMerchants.SelectedIndexChanged += new System.EventHandler(this.cbMerchants_SelectedIndexChanged);
            // 
            // txtLeads
            // 
            this.txtLeads.Location = new System.Drawing.Point(138, 3);
            this.txtLeads.Name = "txtLeads";
            this.txtLeads.Size = new System.Drawing.Size(34, 20);
            this.txtLeads.TabIndex = 1;
            // 
            // txtTrial
            // 
            this.txtTrial.Location = new System.Drawing.Point(183, 3);
            this.txtTrial.Name = "txtTrial";
            this.txtTrial.Size = new System.Drawing.Size(34, 20);
            this.txtTrial.TabIndex = 2;
            // 
            // txtClose
            // 
            this.txtClose.Location = new System.Drawing.Point(228, 3);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(272, 35);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(145, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 220);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

