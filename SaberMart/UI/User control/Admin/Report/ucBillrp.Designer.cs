namespace SaberMart.UI.User_control.Admin.Report
{
    partial class ucBillrp
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
            this.crvBill = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvBill
            // 
            this.crvBill.ActiveViewIndex = -1;
            this.crvBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvBill.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvBill.Location = new System.Drawing.Point(0, 0);
            this.crvBill.Name = "crvBill";
            this.crvBill.Size = new System.Drawing.Size(1167, 813);
            this.crvBill.TabIndex = 0;
            // 
            // ucBillrp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.crvBill);
            this.Name = "ucBillrp";
            this.Size = new System.Drawing.Size(1167, 813);
            this.Load += new System.EventHandler(this.ucBillrp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvBill;
    }
}
