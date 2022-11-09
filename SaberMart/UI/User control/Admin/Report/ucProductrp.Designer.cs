namespace SaberMart.UI.User_control.Admin.Report
{
    partial class ucProductrp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crvProduct = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvProduct
            // 
            this.crvProduct.ActiveViewIndex = -1;
            this.crvProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvProduct.Location = new System.Drawing.Point(0, 0);
            this.crvProduct.Name = "crvProduct";
            this.crvProduct.Size = new System.Drawing.Size(1167, 813);
            this.crvProduct.TabIndex = 0;
            // 
            // ucProductrp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.crvProduct);
            this.Name = "ucProductrp";
            this.Size = new System.Drawing.Size(1167, 813);
            this.Load += new System.EventHandler(this.ucProductrp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProduct;
    }
}
