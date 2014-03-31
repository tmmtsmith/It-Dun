namespace Pricing_Version10
{
    partial class plqau
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
            this.cbSales = new System.Windows.Forms.ComboBox();
            this.cbCP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddCost = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbSales
            // 
            this.cbSales.FormattingEnabled = true;
            this.cbSales.Location = new System.Drawing.Point(12, 31);
            this.cbSales.Name = "cbSales";
            this.cbSales.Size = new System.Drawing.Size(133, 21);
            this.cbSales.TabIndex = 0;
            // 
            // cbCP
            // 
            this.cbCP.FormattingEnabled = true;
            this.cbCP.Items.AddRange(new object[] {
            "Lead",
            "Quote",
            "Trial",
            "Close"});
            this.cbCP.Location = new System.Drawing.Point(151, 31);
            this.cbCP.Name = "cbCP";
            this.cbCP.Size = new System.Drawing.Size(100, 21);
            this.cbCP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cost Per ...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sales Approach:";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(278, 31);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(41, 20);
            this.txtCost.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(117, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 12);
            this.label7.TabIndex = 36;
            this.label7.Text = "© RCSD and RS Consulting Partners";
            // 
            // btnAddCost
            // 
            this.btnAddCost.Location = new System.Drawing.Point(325, 29);
            this.btnAddCost.Name = "btnAddCost";
            this.btnAddCost.Size = new System.Drawing.Size(62, 23);
            this.btnAddCost.TabIndex = 3;
            this.btnAddCost.Text = "Enter";
            this.btnAddCost.UseVisualStyleBackColor = true;
            this.btnAddCost.Click += new System.EventHandler(this.btnAddCost_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Cost:";
            // 
            // plqau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(396, 90);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCP);
            this.Controls.Add(this.cbSales);
            this.Name = "plqau";
            this.Text = "Kristen\'s Piano Studio - Cost Analysis";
            this.Load += new System.EventHandler(this.plqau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSales;
        private System.Windows.Forms.ComboBox cbCP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}