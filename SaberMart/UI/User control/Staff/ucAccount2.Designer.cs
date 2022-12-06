namespace SaberMart.UI.User_control.Staff
{
    partial class ucAccount2
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
            this.paMenu = new DevExpress.XtraEditors.PanelControl();
            this.pAcc = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.paMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // paMenu
            // 
            this.paMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.paMenu.Location = new System.Drawing.Point(0, 0);
            this.paMenu.Name = "paMenu";
            this.paMenu.Size = new System.Drawing.Size(1413, 76);
            this.paMenu.TabIndex = 0;
            // 
            // pAcc
            // 
            this.pAcc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAcc.Location = new System.Drawing.Point(0, 76);
            this.pAcc.Name = "pAcc";
            this.pAcc.Size = new System.Drawing.Size(1413, 1026);
            this.pAcc.TabIndex = 1;
            // 
            // ucAccount2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pAcc);
            this.Controls.Add(this.paMenu);
            this.Name = "ucAccount2";
            this.Size = new System.Drawing.Size(1413, 1102);
            ((System.ComponentModel.ISupportInitialize)(this.paMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAcc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl paMenu;
        private DevExpress.XtraEditors.PanelControl pAcc;
    }
}
