﻿
namespace SaberMart.UI
{
    partial class frmAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.barDockingMenuItem1 = new DevExpress.XtraBars.BarDockingMenuItem();
            this.barDockingMenuItem2 = new DevExpress.XtraBars.BarDockingMenuItem();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.paMenu = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnStaffUC = new System.Windows.Forms.Button();
            this.pAdmin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.paMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barDockingMenuItem1,
            this.barDockingMenuItem2});
            this.fluentFormDefaultManager1.MaxItemId = 2;
            // 
            // barDockingMenuItem1
            // 
            this.barDockingMenuItem1.Id = 0;
            this.barDockingMenuItem1.Name = "barDockingMenuItem1";
            // 
            // barDockingMenuItem2
            // 
            this.barDockingMenuItem2.Caption = "barDockingMenuItem2";
            this.barDockingMenuItem2.Id = 1;
            this.barDockingMenuItem2.Name = "barDockingMenuItem2";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barDockingMenuItem1,
            this.barDockingMenuItem2});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1181, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // paMenu
            // 
            this.paMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.paMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paMenu.Controls.Add(this.btnAccount);
            this.paMenu.Controls.Add(this.btnLogout);
            this.paMenu.Controls.Add(this.btnData);
            this.paMenu.Controls.Add(this.btnStaffUC);
            this.paMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.paMenu.Location = new System.Drawing.Point(0, 39);
            this.paMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paMenu.Name = "paMenu";
            this.paMenu.Size = new System.Drawing.Size(1181, 84);
            this.paMenu.TabIndex = 3;
            this.paMenu.Click += new System.EventHandler(this.paMenu_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.Red;
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAccount.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Swordoflogos", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAccount.Image = global::SaberMart.Properties.Resources.User_32x32;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAccount.Location = new System.Drawing.Point(280, 0);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(140, 80);
            this.btnAccount.TabIndex = 4;
            this.btnAccount.Text = "Account";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.UseWaitCursor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Gray;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Swordoflogos", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(1057, 0);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 80);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.OrangeRed;
            this.btnData.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnData.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnData.Font = new System.Drawing.Font("Swordoflogos", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnData.ForeColor = System.Drawing.SystemColors.Control;
            this.btnData.Image = global::SaberMart.Properties.Resources.product_data;
            this.btnData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnData.Location = new System.Drawing.Point(140, 0);
            this.btnData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(140, 80);
            this.btnData.TabIndex = 2;
            this.btnData.Text = "Data";
            this.btnData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.UseWaitCursor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnStaffUC
            // 
            this.btnStaffUC.BackColor = System.Drawing.Color.Red;
            this.btnStaffUC.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStaffUC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnStaffUC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnStaffUC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnStaffUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffUC.Font = new System.Drawing.Font("Swordoflogos", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffUC.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStaffUC.Image = global::SaberMart.Properties.Resources.staff;
            this.btnStaffUC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStaffUC.Location = new System.Drawing.Point(0, 0);
            this.btnStaffUC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStaffUC.Name = "btnStaffUC";
            this.btnStaffUC.Size = new System.Drawing.Size(140, 80);
            this.btnStaffUC.TabIndex = 1;
            this.btnStaffUC.Text = "STAFF";
            this.btnStaffUC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStaffUC.UseVisualStyleBackColor = false;
            this.btnStaffUC.UseWaitCursor = true;
            this.btnStaffUC.Click += new System.EventHandler(this.btnStaffUC_Click);
            // 
            // pAdmin
            // 
            this.pAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pAdmin.BackgroundImage")));
            this.pAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAdmin.Location = new System.Drawing.Point(0, 123);
            this.pAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pAdmin.Name = "pAdmin";
            this.pAdmin.Size = new System.Drawing.Size(1181, 595);
            this.pAdmin.TabIndex = 4;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1181, 718);
            this.Controls.Add(this.pAdmin);
            this.Controls.Add(this.paMenu);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmAdmin.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAdmin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Saber Mart - Admin";
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.paMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.BarDockingMenuItem barDockingMenuItem1;
        private DevExpress.XtraBars.BarDockingMenuItem barDockingMenuItem2;
        private System.Windows.Forms.Panel pAdmin;
        private System.Windows.Forms.Panel paMenu;
        private System.Windows.Forms.Button btnStaffUC;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnAccount;
    }
}