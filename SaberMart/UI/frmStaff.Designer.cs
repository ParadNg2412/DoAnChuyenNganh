namespace SaberMart.UI
{
    partial class frmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
            this.paMenu = new System.Windows.Forms.Panel();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pStaff = new System.Windows.Forms.Panel();
            this.paMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // paMenu
            // 
            this.paMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.paMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.paMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paMenu.Controls.Add(this.btnBill);
            this.paMenu.Controls.Add(this.btnProduct);
            this.paMenu.Controls.Add(this.btnLogout);
            this.paMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.paMenu.Location = new System.Drawing.Point(0, 0);
            this.paMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paMenu.Name = "paMenu";
            this.paMenu.Size = new System.Drawing.Size(153, 716);
            this.paMenu.TabIndex = 4;
            this.paMenu.Click += new System.EventHandler(this.paMenu_Click);
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.Red;
            this.btnBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBill.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnBill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBill.Image = global::SaberMart.Properties.Resources.bill;
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBill.Location = new System.Drawing.Point(0, 84);
            this.btnBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(149, 94);
            this.btnBill.TabIndex = 7;
            this.btnBill.Text = "Hóa đơn";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Orange;
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProduct.Image = global::SaberMart.Properties.Resources.boproduct_32x32;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProduct.Location = new System.Drawing.Point(0, 0);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(149, 84);
            this.btnProduct.TabIndex = 5;
            this.btnProduct.Text = "Sản phẩm";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Gray;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(0, 636);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(149, 76);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pStaff
            // 
            this.pStaff.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pStaff.BackgroundImage = global::SaberMart.Properties.Resources.KaenkenRekka4;
            this.pStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pStaff.Location = new System.Drawing.Point(153, 0);
            this.pStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pStaff.Name = "pStaff";
            this.pStaff.Size = new System.Drawing.Size(1295, 716);
            this.pStaff.TabIndex = 5;
            // 
            // frmStaff
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1448, 716);
            this.Controls.Add(this.pStaff);
            this.Controls.Add(this.paMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Image = global::SaberMart.Properties.Resources.SaberMart;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmStaff";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Saber Mart - Nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.paMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paMenu;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pStaff;
    }
}