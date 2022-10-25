
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStorage = new DevExpress.XtraEditors.SimpleButton();
            this.pData = new System.Windows.Forms.Panel();
            this.btnBrand = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnBrand);
            this.panel1.Controls.Add(this.btnStorage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 483);
            this.panel1.TabIndex = 0;
            // 
            // btnStorage
            // 
            this.btnStorage.Appearance.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnStorage.Appearance.Font = new System.Drawing.Font("Swordoflogos", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorage.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnStorage.Appearance.Options.UseBackColor = true;
            this.btnStorage.Appearance.Options.UseFont = true;
            this.btnStorage.Appearance.Options.UseForeColor = true;
            this.btnStorage.AppearanceHovered.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnStorage.AppearanceHovered.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorage.AppearanceHovered.Options.UseBackColor = true;
            this.btnStorage.AppearanceHovered.Options.UseFont = true;
            this.btnStorage.AppearancePressed.BackColor = System.Drawing.Color.Black;
            this.btnStorage.AppearancePressed.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorage.AppearancePressed.Options.UseBackColor = true;
            this.btnStorage.AppearancePressed.Options.UseFont = true;
            this.btnStorage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStorage.ImageOptions.Image = global::SaberMart.Properties.Resources.storage;
            this.btnStorage.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnStorage.Location = new System.Drawing.Point(0, 0);
            this.btnStorage.Margin = new System.Windows.Forms.Padding(2);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(107, 53);
            this.btnStorage.TabIndex = 0;
            this.btnStorage.Text = "Storage";
            this.btnStorage.Click += new System.EventHandler(this.btnStorage_Click);
            // 
            // pData
            // 
            this.pData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pData.Location = new System.Drawing.Point(111, 0);
            this.pData.Margin = new System.Windows.Forms.Padding(2);
            this.pData.Name = "pData";
            this.pData.Size = new System.Drawing.Size(901, 483);
            this.pData.TabIndex = 1;
            // 
            // btnBrand
            // 
            this.btnBrand.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.btnBrand.Appearance.Font = new System.Drawing.Font("Swordoflogos", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrand.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnBrand.Appearance.Options.UseBackColor = true;
            this.btnBrand.Appearance.Options.UseFont = true;
            this.btnBrand.Appearance.Options.UseForeColor = true;
            this.btnBrand.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBrand.AppearanceHovered.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrand.AppearanceHovered.Options.UseBackColor = true;
            this.btnBrand.AppearanceHovered.Options.UseFont = true;
            this.btnBrand.AppearancePressed.BackColor = System.Drawing.Color.Black;
            this.btnBrand.AppearancePressed.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrand.AppearancePressed.Options.UseBackColor = true;
            this.btnBrand.AppearancePressed.Options.UseFont = true;
            this.btnBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrand.ImageOptions.Image = global::SaberMart.Properties.Resources.producer;
            this.btnBrand.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBrand.Location = new System.Drawing.Point(0, 53);
            this.btnBrand.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Size = new System.Drawing.Size(107, 53);
            this.btnBrand.TabIndex = 1;
            this.btnBrand.Text = "Brand";
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // ucData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pData);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucData";
            this.Size = new System.Drawing.Size(1012, 483);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnStorage;
        private System.Windows.Forms.Panel pData;
        private DevExpress.XtraEditors.SimpleButton btnBrand;
    }
}
