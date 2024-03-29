﻿
namespace SaberMart.UI.User_control.Admin
{
    partial class ucData
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
            this.pdMenu = new System.Windows.Forms.Panel();
            this.btnProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnBrand = new DevExpress.XtraEditors.SimpleButton();
            this.btnStorage = new DevExpress.XtraEditors.SimpleButton();
            this.pData = new System.Windows.Forms.Panel();
            this.pdMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdMenu
            // 
            this.pdMenu.BackColor = System.Drawing.Color.Black;
            this.pdMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pdMenu.Controls.Add(this.btnProduct);
            this.pdMenu.Controls.Add(this.btnBrand);
            this.pdMenu.Controls.Add(this.btnStorage);
            this.pdMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pdMenu.Location = new System.Drawing.Point(0, 0);
            this.pdMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pdMenu.Name = "pdMenu";
            this.pdMenu.Size = new System.Drawing.Size(147, 594);
            this.pdMenu.TabIndex = 0;
            this.pdMenu.Click += new System.EventHandler(this.pdMenu_Click);
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
            this.btnProduct.Location = new System.Drawing.Point(0, 158);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(143, 82);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "Sản phẩm";
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnBrand
            // 
            this.btnBrand.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.btnBrand.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrand.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnBrand.Appearance.Options.UseBackColor = true;
            this.btnBrand.Appearance.Options.UseFont = true;
            this.btnBrand.Appearance.Options.UseForeColor = true;
            this.btnBrand.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBrand.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrand.AppearanceHovered.Options.UseBackColor = true;
            this.btnBrand.AppearanceHovered.Options.UseFont = true;
            this.btnBrand.AppearancePressed.BackColor = System.Drawing.Color.Black;
            this.btnBrand.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrand.AppearancePressed.Options.UseBackColor = true;
            this.btnBrand.AppearancePressed.Options.UseFont = true;
            this.btnBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrand.ImageOptions.Image = global::SaberMart.Properties.Resources.producer;
            this.btnBrand.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBrand.Location = new System.Drawing.Point(0, 75);
            this.btnBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Size = new System.Drawing.Size(143, 83);
            this.btnBrand.TabIndex = 1;
            this.btnBrand.Text = "Nhà cung cấp";
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // btnStorage
            // 
            this.btnStorage.Appearance.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnStorage.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorage.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnStorage.Appearance.Options.UseBackColor = true;
            this.btnStorage.Appearance.Options.UseFont = true;
            this.btnStorage.Appearance.Options.UseForeColor = true;
            this.btnStorage.AppearanceHovered.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnStorage.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorage.AppearanceHovered.Options.UseBackColor = true;
            this.btnStorage.AppearanceHovered.Options.UseFont = true;
            this.btnStorage.AppearancePressed.BackColor = System.Drawing.Color.Black;
            this.btnStorage.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorage.AppearancePressed.Options.UseBackColor = true;
            this.btnStorage.AppearancePressed.Options.UseFont = true;
            this.btnStorage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStorage.ImageOptions.Image = global::SaberMart.Properties.Resources.storage;
            this.btnStorage.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnStorage.Location = new System.Drawing.Point(0, 0);
            this.btnStorage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(143, 75);
            this.btnStorage.TabIndex = 0;
            this.btnStorage.Text = "Phiếu nhập";
            this.btnStorage.Click += new System.EventHandler(this.btnStorage_Click);
            // 
            // pData
            // 
            this.pData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pData.Location = new System.Drawing.Point(147, 0);
            this.pData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pData.Name = "pData";
            this.pData.Size = new System.Drawing.Size(1202, 594);
            this.pData.TabIndex = 1;
            // 
            // ucData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pData);
            this.Controls.Add(this.pdMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucData";
            this.Size = new System.Drawing.Size(1349, 594);
            this.pdMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pdMenu;
        private DevExpress.XtraEditors.SimpleButton btnStorage;
        private System.Windows.Forms.Panel pData;
        private DevExpress.XtraEditors.SimpleButton btnBrand;
        private DevExpress.XtraEditors.SimpleButton btnProduct;
    }
}
