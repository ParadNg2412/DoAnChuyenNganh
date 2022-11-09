namespace SaberMart.UI.User_control.Admin
{
    partial class ucReport
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
            this.pMenu = new System.Windows.Forms.Panel();
            this.pControl = new System.Windows.Forms.Panel();
            this.btnBill = new DevExpress.XtraEditors.SimpleButton();
            this.btnProduct = new DevExpress.XtraEditors.SimpleButton();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pMenu.Controls.Add(this.btnBill);
            this.pMenu.Controls.Add(this.btnProduct);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(141, 813);
            this.pMenu.TabIndex = 0;
            this.pMenu.Click += new System.EventHandler(this.pMenu_Click);
            // 
            // pControl
            // 
            this.pControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pControl.Location = new System.Drawing.Point(141, 0);
            this.pControl.Name = "pControl";
            this.pControl.Size = new System.Drawing.Size(1167, 813);
            this.pControl.TabIndex = 1;
            // 
            // btnBill
            // 
            this.btnBill.Appearance.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBill.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnBill.Appearance.Options.UseBackColor = true;
            this.btnBill.Appearance.Options.UseFont = true;
            this.btnBill.Appearance.Options.UseForeColor = true;
            this.btnBill.AppearanceHovered.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBill.AppearanceHovered.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.AppearanceHovered.Options.UseBackColor = true;
            this.btnBill.AppearanceHovered.Options.UseFont = true;
            this.btnBill.AppearancePressed.BackColor = System.Drawing.Color.Black;
            this.btnBill.AppearancePressed.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.AppearancePressed.Options.UseBackColor = true;
            this.btnBill.AppearancePressed.Options.UseFont = true;
            this.btnBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBill.ImageOptions.Image = global::SaberMart.Properties.Resources.storage;
            this.btnBill.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBill.Location = new System.Drawing.Point(0, 82);
            this.btnBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(141, 75);
            this.btnBill.TabIndex = 4;
            this.btnBill.Text = "Hóa đơn";
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Appearance.BackColor = System.Drawing.Color.Gold;
            this.btnProduct.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnProduct.Appearance.Options.UseBackColor = true;
            this.btnProduct.Appearance.Options.UseFont = true;
            this.btnProduct.Appearance.Options.UseForeColor = true;
            this.btnProduct.AppearanceHovered.BackColor = System.Drawing.Color.Yellow;
            this.btnProduct.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.AppearanceHovered.Options.UseBackColor = true;
            this.btnProduct.AppearanceHovered.Options.UseFont = true;
            this.btnProduct.AppearancePressed.BackColor = System.Drawing.Color.Black;
            this.btnProduct.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.AppearancePressed.Options.UseBackColor = true;
            this.btnProduct.AppearancePressed.Options.UseFont = true;
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.ImageOptions.Image = global::SaberMart.Properties.Resources.boproduct_32x32;
            this.btnProduct.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnProduct.Location = new System.Drawing.Point(0, 0);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(141, 82);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Sản phẩm";
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // ucReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pControl);
            this.Controls.Add(this.pMenu);
            this.Name = "ucReport";
            this.Size = new System.Drawing.Size(1308, 813);
            this.pMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pControl;
        private DevExpress.XtraEditors.SimpleButton btnProduct;
        private DevExpress.XtraEditors.SimpleButton btnBill;
    }
}
