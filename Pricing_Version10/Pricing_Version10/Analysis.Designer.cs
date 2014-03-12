namespace Pricing_Version10
{
    partial class Analysis
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
            this.dAnalysis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // dAnalysis
            // 
            this.dAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dAnalysis.Location = new System.Drawing.Point(12, 12);
            this.dAnalysis.Name = "dAnalysis";
            this.dAnalysis.Size = new System.Drawing.Size(434, 143);
            this.dAnalysis.TabIndex = 0;
            // 
            // Analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 188);
            this.Controls.Add(this.dAnalysis);
            this.Name = "Analysis";
            this.Text = "Analysis";
            ((System.ComponentModel.ISupportInitialize)(this.dAnalysis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dAnalysis;
    }
}